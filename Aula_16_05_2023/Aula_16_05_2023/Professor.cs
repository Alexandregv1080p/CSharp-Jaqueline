using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_05_2023
{
    internal class Professor: Pessoa
    {
        private string titulacao;

        public string Titulacao { get => titulacao; set => titulacao = value; }
        
        public string MostrarProfessor()
        {
            string aux = "";
            return aux += $"Titulação:{titulacao}, {MostrarPessoa()}";
        }
    }
}
