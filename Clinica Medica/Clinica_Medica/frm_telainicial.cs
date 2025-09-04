using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinica_Medica
{
    public partial class frm_telainicial : Form
    {
        public frm_telainicial()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void médicoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadMedico frmcadmedico = new frmCadMedico();
            frmcadmedico.ShowDialog();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPaciente frmCadPaciente = new frmCadPaciente();
            frmCadPaciente.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAltMedico frmAltMedico = new frmAltMedico();
            frmAltMedico.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAltPaciente frmAltPaciente = new frmAltPaciente();
            frmAltPaciente.ShowDialog();
        }
    }
}
