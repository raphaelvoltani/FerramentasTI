using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas
{
    public partial class DesligaPC : Form
    {
        public DesligaPC()
        {
            InitializeComponent();
        }

        private void btnEscolhaH_Click(object sender, EventArgs e)
        {
            //Obtem o horario selecionado  pelo usuario
            DateTime horariodesligamento = dateTimePicker1.Value;
            
            //Obtem hora atual
            DateTime agora = DateTime.Now;

            //Calcula o tempo restante até o horario especifico
            TimeSpan temporestante = horariodesligamento - agora;

            //Converte tempo para segundos
            int temporestantesegundos = (int)temporestante.TotalSeconds;

            //Executa o comando para desligar
            Process.Start(new ProcessStartInfo(
                "shutdown", $"/s /t {temporestantesegundos}")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
            });
        }

        private void btnCancelaDesl_Click(object sender, EventArgs e)
        {
            //Cancela o comando para desligar
            Process.Start(new ProcessStartInfo(
                "shutdown", $"/a")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
            });
            MessageBox.Show("Desligamento Cancelado");
        }
    }
}
