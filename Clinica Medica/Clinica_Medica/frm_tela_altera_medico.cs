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
    public partial class frm_tela_altera_medico : Form
    {
        string _conexao = Clinica_Medica.Properties.Settings.Default.conexao;

        public frm_tela_altera_medico(int codigo)
        {
            InitializeComponent();

            if (codigo > 0)
            {
                Medicos medicos = new Medicos();

                Medicos_DAO medicosDAO = new Medicos_DAO(_conexao);

                medicos = medicosDAO.ObtemMedicos(codigo);

                if (medicos == null)
                {
                    MessageBox.Show("Médico não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.Close();
                }

                lab_codmed2.Text = medicos.cod_medico.ToString();
                txb_nomemedico.Text = medicos.nome_medico;
                msk_cpfmedico.Text = medicos.cpf_medico;
                dtp_nascmedico.Value = medicos.dtnasc_medico;
                msk_telmedico.Text = medicos.tel_medico;
                txb_emailmedico.Text = medicos.email_medico;
                txb_crmmedico.Text = medicos.crm_medico;
                txb_especmedico.Text = medicos.espec_medico;
            }
        }
        

        private void btm_voltaraddmedico_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btm_gravaraddmedico_Click(object sender, EventArgs e)
        {
            Medicos medicos = new Medicos();

            Medicos_DAO medicosDAO = new Medicos_DAO(_conexao);

            try
            {
                medicos.cod_medico = Convert.ToInt32(lab_codmed2.Text);
                medicos.nome_medico = txb_nomemedico.Text;
                medicos.cpf_medico = msk_cpfmedico.Text;
                medicos.dtnasc_medico = dtp_nascmedico.Value;
                medicos.tel_medico = msk_telmedico.Text;
                medicos.email_medico = txb_emailmedico.Text;
                medicos.crm_medico = txb_crmmedico.Text;
                medicos.espec_medico = txb_especmedico.Text;

                int codigo = Convert.ToInt32(lab_codmed2.Text);

                medicos.cod_medico = codigo;

                medicosDAO.AlteraMedicos(medicos);

                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!" + erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lab_codmed2_Click(object sender, EventArgs e)
        {

        }
    }
}
