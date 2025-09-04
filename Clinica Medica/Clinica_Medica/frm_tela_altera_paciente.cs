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
    

    public partial class frm_tela_altera_paciente : Form
    {
        string _conexao = Clinica_Medica.Properties.Settings.Default.conexao;
        
        public frm_tela_altera_paciente(int codigo)
        {
            InitializeComponent();

            if (codigo > 0)
            {
                Pacientes pacientes = new Pacientes();

                Pacientes_DAO pacientes_DAO = new Pacientes_DAO(_conexao);
                string est_civil, tipo_sang, RH;

                pacientes = pacientes_DAO.ObtemPacientes(codigo);

                if (pacientes == null)
                {
                    MessageBox.Show("Paciente não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {


                    lab_codpac2.Text = pacientes.cod_paciente.ToString();
                    txb_pacien_nome.Text = pacientes.nome_paciente;
                    msk_pacien_cpf.Text = pacientes.cpf_paciente;
                    dtp_pacien_datanasc.Value = pacientes.dtnasc_paciente;
                    msk_pacien_tel.Text = pacientes.tel_paciente;
                    txb_pacien_email.Text = pacientes.email_paciente;
                    est_civil = pacientes.estadociv_paciente;
                    tipo_sang = pacientes.tiposang_paciente;
                    RH = pacientes.rh_paciente;
                    msk_paciente_cep.Text = pacientes.cep_paciente;
                    txb_pacien_logradouro.Text = pacientes.logradouro_paciente;
                    txb_pacien_numero.Text = pacientes.numero_paciente;
                    txb_pacien_bairro.Text = pacientes.bairro_paciente;
                    cmb_pacien_uf.Text = pacientes.uf_paciente;
                    txb_pacien_complemento.Text = pacientes.complemento_paciente;
                    txb_pacien_cidade.Text = pacientes.cidade_paciente;
                    txb_pacien_nomeacomp.Text = pacientes.nomeacomp_paciente;
                    msk_pac_acompanhante_tel.Text = pacientes.telacomp_paciente;

                    if (est_civil == "Divorciado")
                    {
                        radbt_estciv_divorciado.Checked = true;
                    }
                    else if (est_civil == "Casado")
                    {
                        radbt_estciv_casado.Checked = true;
                    }
                    else if (est_civil == "Separado")
                    {
                        radbt_estciv_separado.Checked = true;
                    }
                    else if (est_civil == "Solteiro")
                    {
                        radbt_estciv_solteiro.Checked = true;
                    }
                    else
                    {
                        radbt_estciv_viuvo.Checked = true;
                    }

                    if (tipo_sang == "A")
                    {
                        radbt_tipsag_a.Checked = true;
                    }
                    else if(tipo_sang == "B")
                    {
                        radbt_tipsag_b.Checked = true;
                    }
                    else if( tipo_sang == "AB")
                    {
                        radbt_tipsag_ab.Checked = true;
                    }
                    else
                    {
                        radbt_tipsag_o.Checked = true;
                    }


                    if ( RH == "Positivo")
                    {
                        radbt_rh_positivo.Checked = true;
                    }
                    else
                    {
                        radbt_rh_negativo.Checked = true;
                    }






                    if  (string.IsNullOrWhiteSpace(txb_pacien_nomeacomp.Text))
                    {
                        ckb_paciente_acompanhante.Checked = false;
                    }
                    else
                    {
                        ckb_paciente_acompanhante.Checked = true;
                    }
                }


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



                int codigo = Convert.ToInt32(lab_codpac2.Text);

                pacientes.cod_paciente = codigo;

                pacientes_DAO.AlteraPacientes(pacientes);

                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro!" + erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckb_paciente_acompanhante_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_paciente_acompanhante.Checked)
            {
                gbx_cadpacientesacomp.Visible = true;
            }

            else
            {
                gbx_cadpacientesacomp.Visible = false;
            }
        }
    }
}
