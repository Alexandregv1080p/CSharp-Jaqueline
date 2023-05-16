using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_05_2023
{
    internal class Aluno: Pessoa
    {
        private string matricula;

        public string Matricula { get => matricula; set => matricula = value; }

        public string MostrarAluno()
        {
            string aux = "";
            return aux += $"Matricula: {matricula}, {MostrarPessoa()}";
        }
    }
}
