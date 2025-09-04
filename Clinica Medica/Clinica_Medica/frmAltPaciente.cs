using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinica_Medica___DATA;

namespace Clinica_Medica
{
    public partial class frmAltPaciente : Form
    {
        string _conexao = Clinica_Medica.Properties.Settings.Default.conexao;

        public frmAltPaciente()
        {
            InitializeComponent();
            ListarPacientes();
            configuraDataGridPaciente();
        }

        private void frmAltPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'med_CliDataSet1.Pacientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pacientesTableAdapter.Fill(this.med_CliDataSet1.Pacientes);

        }

        private void btn_alt_pac_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_alt_pac_incluir_Click(object sender, EventArgs e)
        {
            frmCadPaciente frmCadPaciente = new frmCadPaciente();
            frmCadPaciente.ShowDialog();
        }

        private void configuraDataGridPaciente()
        {
            dataGridView_alt_paciente.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dataGridView_alt_paciente.RowHeadersWidth = 25;



            dataGridView_alt_paciente.Columns["cod_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; //ajusta baseado apenas no titulo
            dataGridView_alt_paciente.Columns["cod_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_alt_paciente.Columns["cod_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_alt_paciente.Columns["cod_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["cod_paciente"].HeaderText = "Codigo";
            
            dataGridView_alt_paciente.Columns["nome_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; 
            dataGridView_alt_paciente.Columns["nome_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_alt_paciente.Columns["nome_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_alt_paciente.Columns["nome_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["nome_paciente"].HeaderText = "Nome";
            
            dataGridView_alt_paciente.Columns["cpf_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["cpf_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["cpf_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["cpf_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["cpf_paciente"].HeaderText = "CPF";
            
            dataGridView_alt_paciente.Columns["dtnasc_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["dtnasc_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["dtnasc_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["dtnasc_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["dtnasc_paciente"].HeaderText = "Data de Nascimento";
            
            dataGridView_alt_paciente.Columns["tel_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["tel_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["tel_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["tel_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["tel_paciente"].HeaderText = "Telefone";
            
            dataGridView_alt_paciente.Columns["email_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["email_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["email_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["email_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["email_paciente"].HeaderText = "Email";
          
            dataGridView_alt_paciente.Columns["estadociv_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["estadociv_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["estadociv_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["estadociv_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["estadociv_paciente"].HeaderText = "Estado Civil";
            
            dataGridView_alt_paciente.Columns["tiposang_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["tiposang_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["tiposang_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["tiposang_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["tiposang_paciente"].HeaderText = "Tipo Sanguineo";

            dataGridView_alt_paciente.Columns["rh_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["rh_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_alt_paciente.Columns["rh_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_alt_paciente.Columns["rh_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["rh_paciente"].HeaderText = "RH";

            dataGridView_alt_paciente.Columns["cep_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["cep_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_alt_paciente.Columns["cep_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_alt_paciente.Columns["cep_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["cep_paciente"].HeaderText = "CEP";

            dataGridView_alt_paciente.Columns["logradouro_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["logradouro_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["logradouro_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["logradouro_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["logradouro_paciente"].HeaderText = "Logradouro";

            dataGridView_alt_paciente.Columns["numero_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["numero_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["numero_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["numero_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["numero_paciente"].HeaderText = "Numero";

            dataGridView_alt_paciente.Columns["bairro_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["bairro_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["bairro_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["bairro_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["bairro_paciente"].HeaderText = "Bairro";

            dataGridView_alt_paciente.Columns["uf_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["uf_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["uf_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["uf_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["uf_paciente"].HeaderText = "UF";

            dataGridView_alt_paciente.Columns["complemento_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["complemento_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["complemento_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["complemento_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["complemento_paciente"].HeaderText = "Complemento";

            dataGridView_alt_paciente.Columns["cidade_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["cidade_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["cidade_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["cidade_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["cidade_paciente"].HeaderText = "Cidade";

            dataGridView_alt_paciente.Columns["nomeacomp_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["nomeacomp_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["nomeacomp_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["nomeacomp_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["nomeacomp_paciente"].HeaderText = "Nome do Acompanhante";

            dataGridView_alt_paciente.Columns["telacomp_paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_paciente.Columns["telacomp_paciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_paciente.Columns["telacomp_paciente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_paciente.Columns["telacomp_paciente"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_paciente.Columns["telacomp_paciente"].HeaderText = "Paciente";
        }


        private void ListarPacientes()
        {
            Pacientes_DAO Pacientes_DAO = new Pacientes_DAO(_conexao);

            string busca = txb_alt_pacin_buscar.Text.ToString();

            DataSet dspaciente = new DataSet();
            dspaciente = Pacientes_DAO.BuscaPaciente(busca);

            dataGridView_alt_paciente.DataSource = dspaciente;
            dataGridView_alt_paciente.DataMember = "Pacientes";
        }

        private void btn_busca_pac_Click(object sender, EventArgs e)
        {
            if (txb_alt_pacin_buscar.Text == "")
            {
                MessageBox.Show("Informe um conteúdo !");

                txb_alt_pacin_buscar.Focus();

                return;
            }

            ListarPacientes();
        }

        private void btn_alt_pac_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView_alt_paciente.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dataGridView_alt_paciente.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show("Deseja excluir esse registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    Pacientes_DAO pacientes_DAO = new Pacientes_DAO(_conexao);

                    pacientes_DAO.ExcluiPaciente(codigo);

                    ListarPacientes();
                }

                else
                {
                    MessageBox.Show("Selecione um registro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_alt_pac_alterar_Click(object sender, EventArgs e)
        {
            if (dataGridView_alt_paciente.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dataGridView_alt_paciente.CurrentRow.Cells[0].Value);

                frm_tela_altera_paciente frm_Tela_Altera_Paciente = new frm_tela_altera_paciente(codigo);

                frm_Tela_Altera_Paciente.ShowDialog();

                ListarPacientes();

                
            }
            else
            {
                    MessageBox.Show("Selecione um registro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                  

        }
    }
}
