using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class Funcionario
    {
        
        private string nome;

        public Funcionario(string nome) => this.nome = nome;
      

        public string MostraFuncionario()
        {
            string aux = "";
            return aux += $"{nome}";
        }
    }
}
