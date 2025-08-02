using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ferramentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limparPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EXIBE UMA MENSAGEM DE CONFIRMAÇÃO
            var result = MessageBox.Show("JA FALEI QUE VAI DA MERDA ISSO DAI!!!",
                "confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //CAPTURA O CAMINHO DA PASTA TEMPORÁRIO DO WINDOWS
                string tempPath = Path.GetTempPath();
                //RODAR METODO PARA APAGAR OS ARQUIVOS QUE VAMOS CRIAR
                DeletarArquivosTemporarios(tempPath);
            } 

        }

        private void DeletarArquivosTemporarios(string tempPath)
        {
            //TENTE DELETAR
            try
            {
                //SE A PASTA EXISTIR    
                if (Directory.Exists(tempPath))
                {
                    DirectoryInfo di = new DirectoryInfo(tempPath);

                    //DELETA TODAS OS ARQUIVOS ENCONTRADOS
                        foreach(FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                        // DELETA TODAS AS PASTAS
                        foreach(DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete();
                    }
                }
                else
                {
                    MessageBox.Show("A Pasta não existe !",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = $"Sistema Operacional:{Environment.OSVersion}\n" +
                          $"Arquitetura:{(Environment.Is64BitOperatingSystem ? "64 Bits" : "32")}\n" +
                          $"Processador: {System.Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")}";

            MessageBox.Show(info);
        }

        private void desligaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Criar uma instancia ('Conexão') com o form 2
            DesligaPC desliga = new DesligaPC();

            desliga.ShowDialog();
        }
    }
}
