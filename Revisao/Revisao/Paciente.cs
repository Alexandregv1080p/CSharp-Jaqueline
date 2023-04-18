using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    class Paciente
    {
        private TEndereco end = new TEndereco();
        private int idade;
        private string nome;

        public int Idade { get => idade; set => idade = value; }
        public string Nome { get { return nome; } }
        internal TEndereco End { get { return end; } }

        public Paciente(string nome)
        {
            this.nome = nome;
           
        }
    }
}
