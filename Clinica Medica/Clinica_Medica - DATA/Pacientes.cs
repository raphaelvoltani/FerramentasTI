using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Clinica_Medica___DATA
{
    public class Pacientes
    {
        public int      cod_paciente { get; set; }
        public string   nome_paciente { get; set; }
        public string   cpf_paciente { get; set; }
        public DateTime dtnasc_paciente { get; set; }
        public string   tel_paciente { get; set; }
        public string   email_paciente { get; set; }
        public string   estadociv_paciente { get; set; }
        public string   tiposang_paciente { get; set; }
        public string   rh_paciente { get; set; }
        public string   cep_paciente { get; set; }
        public string   logradouro_paciente { get; set; }
        public string   numero_paciente { get; set; }
        public string   bairro_paciente { get; set; }
        public string   uf_paciente { get; set; }
        public string   complemento_paciente { get; set; }
        public string   cidade_paciente { get; set; }
        public string   nomeacomp_paciente { get; set; }
        public string   telacomp_paciente { get; set; }

    }
}
