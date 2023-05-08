using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05_POO
{
    internal class Pessoa
    {
        private string cpf;
        private int idade;
        private string nome;

        public string Cpf { set => cpf = value; }
        public int Idade { set => idade = value; }
        public string Nome { set => nome = value; }

        public string mostra()
        {
            string aux = "";
            return aux += $"Cpf: {cpf},Idade:{idade},Nome:{nome} ";
        }
    }
}
