using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05_POO
{
    internal class Paciente: Pessoa
    {
        private string plano;

        public string Plano { get => plano; set => plano = value; }

        public string MostrarPaciente()
        {
            string aux = "";
            aux += mostra();
            return aux += $"\nPlano: {Plano}";

        }
    }
}
