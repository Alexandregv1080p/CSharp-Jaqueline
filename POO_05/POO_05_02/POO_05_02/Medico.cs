using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_05_02
{
    internal class Medico:Pessoa
    {
        private string crm;
        private string especialidade;
        public Medico(string nome, int idade, string cpf, string crm, string especialidade): base(nome, idade, cpf)
        {
            this.crm = crm;
            this.especialidade = especialidade;
        }

        public string MostrarMedico()
        {
            string aux = "";
            aux += base.mostra() + "\n";
            return aux += $"Crm: {crm}, Especialidade:{especialidade}";
        }
    }
}
