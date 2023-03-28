using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }

        public string Mostra()
        {
            return "Nome : " + nome + ", Idade: " + idade;
        }
    }
}
