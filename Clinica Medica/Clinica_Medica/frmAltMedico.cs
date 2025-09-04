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
    public partial class frmAltMedico : Form
    {
        string _conexao = Clinica_Medica.Properties.Settings.Default.conexao;

        public frmAltMedico()
        {
            InitializeComponent();
            ListarMedicos();
            configuraDataGridMedico();
        }

        private void configuraDataGridMedico()
        {
            dataGridView_alt_medico.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dataGridView_alt_medico.RowHeadersWidth = 25;



            dataGridView_alt_medico.Columns["cod_medico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; //ajusta baseado apenas no titulo
            dataGridView_alt_medico.Columns["cod_medico"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_alt_medico.Columns["cod_medico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_alt_medico.Columns["cod_medico"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_medico.Columns["cod_medico"].HeaderText = "Codigo";

            dataGridView_alt_medico.Columns["nome_medico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; //ajusta baseado apenas no titulo
            dataGridView_alt_medico.Columns["nome_medico"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_alt_medico.Columns["nome_medico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_alt_medico.Columns["nome_medico"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_medico.Columns["nome_medico"].HeaderText = "Nome";

            dataGridView_alt_medico.Columns["cpf_medico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_medico.Columns["cpf_medico"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_medico.Columns["cpf_medico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_medico.Columns["cpf_medico"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_medico.Columns["cpf_medico"].HeaderText = "CPF";

            dataGridView_alt_medico.Columns["dtnasc_medico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_medico.Columns["dtnasc_medico"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_medico.Columns["dtnasc_medico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_medico.Columns["dtnasc_medico"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_medico.Columns["dtnasc_medico"].HeaderText = "Data de Nascimento";

            dataGridView_alt_medico.Columns["tel_medico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_medico.Columns["tel_medico"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_medico.Columns["tel_medico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_medico.Columns["tel_medico"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_medico.Columns["tel_medico"].HeaderText = "Telefone";

            dataGridView_alt_medico.Columns["email_medico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_medico.Columns["email_medico"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_medico.Columns["email_medico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_medico.Columns["email_medico"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_medico.Columns["email_medico"].HeaderText = "Email";

            dataGridView_alt_medico.Columns["crm_medico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_medico.Columns["crm_medico"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_medico.Columns["crm_medico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_medico.Columns["crm_medico"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_medico.Columns["crm_medico"].HeaderText = "CRM";

            dataGridView_alt_medico.Columns["espec_medico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView_alt_medico.Columns["espec_medico"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView_alt_medico.Columns["espec_medico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_alt_medico.Columns["espec_medico"].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dataGridView_alt_medico.Columns["espec_medico"].HeaderText = "Especialidade";

        }



        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmAltMedico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'med_CliDataSet.Medicos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicosTableAdapter.Fill(this.med_CliDataSet.Medicos);

        }

        private void btn_alt_med_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_alt_med_add_Click(object sender, EventArgs e)
        {
            var InsereMedico = new frmCadMedico();
            InsereMedico.ShowDialog();
            ListarMedicos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_busca_med_Click(object sender, EventArgs e)
        {
            if (txb_alt_med_buscar.Text == "")
            {
                MessageBox.Show("Informe um conteúdo !");

                txb_alt_med_buscar.Focus();

                return;
            }

            ListarMedicos();
        }

        private void ListarMedicos()
        {
            Medicos_DAO medicos_DAO = new Medicos_DAO(_conexao);

            string busca = txb_alt_med_buscar.Text.ToString();

            DataSet dsmedico = new DataSet();
            dsmedico = medicos_DAO.BuscaMedico(busca);

            dataGridView_alt_medico.DataSource = dsmedico;
            dataGridView_alt_medico.DataMember = "Medicos";
        }

        private void btn_alt_med_exclui_Click(object sender, EventArgs e)
        {
            if (dataGridView_alt_medico.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dataGridView_alt_medico.CurrentRow.Cells[0].Value);

                var resultado = MessageBox.Show("Deseja excluir esse registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    Medicos_DAO medicos_DAO = new Medicos_DAO(_conexao);

                    medicos_DAO.ExcluiMedico(codigo);

                    ListarMedicos();
                }

                else
                {
                    MessageBox.Show("Selecione um registro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_alt_med_altera_Click(object sender, EventArgs e)
        {
            if (dataGridView_alt_medico.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dataGridView_alt_medico.CurrentRow.Cells[0].Value);

                frm_tela_altera_medico frm_Tela_Altera_Medico = new frm_tela_altera_medico(codigo);

                frm_Tela_Altera_Medico.ShowDialog();

                ListarMedicos();

            }
            else
            {
                MessageBox.Show("Selecione um registro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
