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
    public partial class frmCadPaciente : Form
    {

        string _conexao = Clinica_Medica.Properties.Settings.Default.conexao;


        public frmCadPaciente()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckb_paciente_acompanhante_CheckedChanged(object sender, EventArgs e)
        {
           if(ckb_paciente_acompanhante.Checked)
            {
                gbx_cadpacientesacomp.Visible = true;
            }

            else
            {
                gbx_cadpacientesacomp.Visible = false;
            }
        }

        private void btm_addpacien_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btm_addpacien_gravar_Click(object sender, EventArgs e)
        {
            Pacientes pacientes = new Pacientes();
            Pacientes_DAO pacientes_DAO = new Pacientes_DAO(_conexao);
            string est_civil, tipo_sang, RH;


            if (string.IsNullOrWhiteSpace(txb_pacien_nome.Text))
            {
                MessageBox.Show("Prencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lab_cadpac_nome.ForeColor = Color.Red;
            }
            

            else
            {
                lab_cadpac_nome.ForeColor = Color.Black;
                try
                {
                   

                    if (radbt_estciv_solteiro.Checked == true)
                    {
                        est_civil = "Solteiro";
                    }
                    else if (radbt_estciv_casado.Checked == true)
                    {
                        est_civil = "Casado";
                    }
                    else if (radbt_estciv_separado.Checked == true)
                    {
                        est_civil = "Separado";

                    }
                    else if (radbt_estciv_divorciado.Checked == true)
                    {
                        est_civil = "Divorciado";

                    }
                    else 
                    {
                        est_civil = "Viuvo";
                    }

                    if (radbt_tipsag_a.Checked == true)
                    {
                        tipo_sang = "A";
                    }
                    else if (radbt_tipsag_b.Checked == true)
                    {
                        tipo_sang = "B";
                    }
                    else if (radbt_tipsag_o.Checked == true)
                    {
                        tipo_sang = "O";
                    }
                    else 
                    {
                        tipo_sang = "AB";
                    }
                    if (radbt_rh_negativo.Checked == true)
                    {
                        RH = "Negativo";
                    }
                    else
                    {
                        RH = "Positivo";
                    }
                    


                    pacientes.nome_paciente = txb_pacien_nome.Text;
                    pacientes.cpf_paciente = msk_pacien_cpf.Text;
                    pacientes.dtnasc_paciente = dtp_pacien_datanasc.Value;
                    pacientes.tel_paciente = msk_pacien_tel.Text;
                    pacientes.email_paciente = txb_pacien_email.Text;
                    pacientes.estadociv_paciente = est_civil;
                    pacientes.tiposang_paciente = tipo_sang;
                    pacientes.rh_paciente = RH;
                    pacientes.cep_paciente = msk_paciente_cep.Text;
                    pacientes.logradouro_paciente = txb_pacien_logradouro.Text;
                    pacientes.numero_paciente = txb_pacien_numero.Text;
                    pacientes.bairro_paciente = txb_pacien_bairro.Text;
                    pacientes.uf_paciente = cmb_pacien_uf.Text;
                    pacientes.complemento_paciente = txb_pacien_complemento.Text;
                    pacientes.cidade_paciente = txb_pacien_cidade.Text;
                    pacientes.nomeacomp_paciente = txb_pacien_nomeacomp.Text;
                    pacientes.telacomp_paciente = msk_pac_acompanhante_tel.Text;

                    pacientes_DAO.IncluirPaciente(pacientes);

                    MessageBox.Show("Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    txb_pacien_nome.Text = string.Empty;
                    msk_pacien_cpf.Text = string.Empty;
                    dtp_pacien_datanasc.Text = string.Empty;
                    msk_pacien_tel.Text = string.Empty;
                    txb_pacien_email.Text = string.Empty;
                    radbt_estciv_casado.Checked = false;
                    radbt_estciv_divorciado.Checked = false;
                    radbt_estciv_separado.Checked = false;
                    radbt_estciv_solteiro.Checked = false;
                    radbt_estciv_viuvo.Checked = false;
                    radbt_tipsag_a.Checked = false;
                    radbt_tipsag_ab.Checked = false;
                    radbt_tipsag_b.Checked = false;
                    radbt_tipsag_o.Checked = false;
                    radbt_rh_negativo.Checked = false;
                    radbt_rh_positivo.Checked = false;
                    msk_paciente_cep.Text = string.Empty;
                    txb_pacien_logradouro.Text = string.Empty;
                    txb_pacien_numero.Text = string.Empty;
                    txb_pacien_bairro.Text = string.Empty;
                    cmb_pacien_uf.Text = string.Empty;
                    txb_pacien_complemento.Text = string.Empty;
                    txb_pacien_cidade.Text = string.Empty;
                    ckb_paciente_acompanhante.Checked = false;
                    txb_pacien_nomeacomp.Text = string.Empty;
                    msk_pac_acompanhante_tel.Text = string.Empty;

                    txb_pacien_nome.Focus();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro" + erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void radbt_estciv_separado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
