using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;
using Clinica_Medica___DATA;

namespace Clinica_Medica
{
    public partial class frmCadMedico : Form
    {
        string _conexao = Clinica_Medica.Properties.Settings.Default.conexao;

        public frmCadMedico()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lab_telmedico_Click(object sender, EventArgs e)
        {

        }

        private void btm_voltaraddmedico_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btm_gravaraddmedico_Click(object sender, EventArgs e)
        {
            Medicos medicos = new Medicos();
            Medicos_DAO medicos_DAO = new Medicos_DAO(_conexao);

            if(string.IsNullOrWhiteSpace(txb_nomemedico.Text))
            {
                MessageBox.Show("Prencha todos os campos","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                lab_nomemedico.ForeColor = Color.Red;
            }

            else
            {
                lab_nomemedico.ForeColor = Color.Black;
                try
                {
                    medicos.nome_medico = txb_nomemedico.Text;
                    medicos.cpf_medico = msk_cpfmedico.Text;
                    medicos.dtnasc_medico = dtp_nascmedico.Value;
                    medicos.tel_medico = msk_telmedico.Text;
                    medicos.email_medico = txb_emailmedico.Text;
                    medicos.crm_medico = txb_crmmedico.Text;
                    medicos.espec_medico = txb_especmedico.Text;

                    medicos_DAO.IncluirMedico(medicos);

                    MessageBox.Show("Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    txb_nomemedico.Text = string.Empty;
                    msk_cpfmedico.Text = string.Empty;
                    msk_telmedico.Text = string.Empty;
                    txb_emailmedico.Text = string.Empty;
                    txb_crmmedico.Text = string.Empty;
                    txb_especmedico.Text = string.Empty;
                    txb_nomemedico.Focus();
                }
                catch(Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro" + erro, "Atenção", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }
    }
}
