using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_05_02
{
    internal class Pessoa
    {
        private string cpf;
        private int idade;
        private string nome;
       
        public Pessoa(string cpf, int idade, string nome)
        {
            this.cpf = cpf;
            this.idade = idade;
            this.nome = nome;
        }

        public string mostra()
        {
            string aux = "";
            return aux += $"Cpf: {cpf},Idade:{idade},Nome:{nome} ";
        }
    }
}
