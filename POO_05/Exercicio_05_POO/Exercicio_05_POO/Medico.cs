using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05_POO
{
    internal class Medico:Pessoa
    {
        private string crm;
        private string especialidade;

        public string Crm { set => crm = value; }
        public string Especialidade { set => especialidade = value; }

        public string MostrarMedico()
        {
            string aux = "";
            aux += base.mostra() + "\n";
            return aux += $"Crm: {crm}, Especialidade:{especialidade}";
        }
    }
}
