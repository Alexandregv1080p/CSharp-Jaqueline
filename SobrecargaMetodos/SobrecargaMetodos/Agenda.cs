using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodos
{
    internal class Agenda
    {
        private string nome;
        private string cidade;
        private int idade;

        public Agenda() { }

        public Agenda(string nome)
        {
            this.nome = nome;
        }
        public Agenda(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public Agenda(string nome, string cidade, int idade)
        {
            this.nome = nome;
            this.cidade = cidade;
            this.idade = idade;
        }
        public string Mostra()
        {
            return nome + " - " + idade.ToString() + " - " + cidade;
        }
    }
}
