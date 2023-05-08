using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_05_02
{
    internal class Paciente:Pessoa
    {
        private string plano;
        public Paciente(string nome, int idade, string cpf, string plano) : base(cpf, idade, nome) => this.plano = plano;
       

        public string MostrarPaciente()
        {
            string aux = "";
            aux += base.mostra() + "\n";
            return aux += $"Plano: {plano}";
        }
    }
}
