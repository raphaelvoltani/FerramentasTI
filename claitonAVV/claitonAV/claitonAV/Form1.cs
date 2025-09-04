using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace claitonAV
{
    public partial class ClaitonAV : MetroForm
    {
        private readonly string _conexao = claitonAV.Properties.Settings.Default._conexao;

        public ClaitonAV()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            // Abrir Arquivo via Explorer Dialogo
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Todos os Arquivos (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = ofd.FileName;
                    try
                    {
                        string hashSHA256 = CalcularHashSHA256(caminhoArquivo);
                        Clipboard.SetText(hashSHA256);
                        MetroMessageBox.Show(this,
                            $"Hash do arquivo \n{hashSHA256}",
                            "Hash Calculado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MetroMessageBox.Show(this,
                            $"ERRO AO CALCULAR!",
                            "Hash Calculado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        private string CalcularHashSHA256(string caminhoArquivo)
        {
            // Abrir o arquivo em modo de leitura
            using (FileStream fs = File.OpenRead(caminhoArquivo))
            using (SHA256 sha256 = SHA256.Create()) 
            {
                // Computa a hash do arquivo e converte os bytes
                byte[] hashBytes = sha256.ComputeHash(fs);
                // Retorna o valor como string
                return BitConverter.ToString(hashBytes)
                                   .Replace("-", "")
                                   .ToLower(); 
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "Todos os Arquivos (*.*)|*.*";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    EscanearArquivo(ofd.FileNames);
                }
            }
        }

        private void EscanearArquivo(string[] fileNames)
        {
            foreach (string fileName in fileNames)
            {
                string hash = CalcularHashSHA256(fileName);
                bool infectado = EhVirus(hash);
                string titulo = infectado ? "Arquivo do MAUU" : "Limpo !";
                string mensagem = infectado ? $"o Arquivo" +
                    $" \"{Path.GetFileName(fileName)}\" Está Infectado" :
                    $"O Arquivo \"{Path.GetFileName(fileName)}\" Limpo";

                MessageBoxIcon icone = infectado ?
                    MessageBoxIcon.Warning : MessageBoxIcon.Error;
                MessageBoxButtons botoes = infectado ?
                    MessageBoxButtons.YesNo : MessageBoxButtons.OK;
                DialogResult resultado = MetroMessageBox.Show(
                    this,
                    mensagem,
                    titulo,
                    botoes,
                    icone
                    );
                if (infectado && resultado == DialogResult.Yes)
                {
                    ExcluirArquivo(fileName);
                }
                RegistrarLog(fileName, hash, infectado ? 
                    "Infectado" : "Limpo");
             } 
        }

        private void RegistrarLog(string fileName, string hash, string v)
        {
            using (SqlConnection conexao = new SqlConnection(_conexao))
            {
                conexao.Open();
                string query = "INSERT INTO logs_escaneamento (caminho_arquivo, hash_calculado, status_arq)" +
                    "VALUES (@caminho, @hash, @status)";
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@caminho", fileName);
                    comando.Parameters.AddWithValue("@hash", hash);
                    comando.Parameters.AddWithValue("@status", v);
                    comando.ExecuteNonQuery();
                }
            }
        }

        private void ExcluirArquivo(string fileName)
        {
            // Vericação se o arquivo existe no caminho Fornecido 
            if (File.Exists(fileName))
            {
                File.Delete(fileName); // Exclui o arquivo 
                // Mostra uma mensagem informando que o arquivo foi excluído com sucesso.
                MetroMessageBox.Show(
                    this,
                    $"Arquivo \"{Path.GetFileName(fileName)}\" excluído com sucesso",
                    "Arquivo Excluido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information );
            }
            else
            {
                MetroMessageBox.Show(
                    this,
                    $"Arquivo \"{Path.GetFileName(fileName)}\" não foi encontrado",
                    "Erro ao Excluir",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private bool EhVirus(string hash)
        {
            // Cria uma Conexão com o banco de dados usando a String de conexão 
            using (SqlConnection conexao = new SqlConnection(_conexao))
            {
                // Abre a conexão 
                conexao.Open();
                // Define a consulta SQL 
                string query = "Select count(*) from assinaturas_de_virus where hash_assinatura = @hash";

                // Cria um comando SQL associando à consulta e à conexão aberta.
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    // Adiciona o valor hash como parametro na consulta SQL
                    comando.Parameters.AddWithValue("@hash", hash);
                    // Executa o comando SQL e obtem o resultado 
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
