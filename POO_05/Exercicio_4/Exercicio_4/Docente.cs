using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Docente : Funcionario
    {
        private string formacao;

        public string Formacao { get => formacao; set => formacao = value; }

        public string MostrarFormacao()
        {
            return $"{Formacao}";
        }
    }
}
