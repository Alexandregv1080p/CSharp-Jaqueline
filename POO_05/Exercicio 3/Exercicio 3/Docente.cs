using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class Docente : Funcionario
    {
        private string formacao;
        public Docente(string formacao,string nome):base(nome) => this.formacao = formacao; 

        public string MostrarFormacao()
        {
            return $"{formacao}";
        }
    }
}
