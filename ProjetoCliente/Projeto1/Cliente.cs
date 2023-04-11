using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    internal class Cliente
    {
        private TCPF objeto_cpf;
        private string nome;
        private int idade;

        public string Nome { get => nome; set => nome = value; }

        public int Idade { get => idade; set => idade = value; }
        internal TCPF Objeto_cpf { get => objeto_cpf; set => objeto_cpf = value; }

        public Cliente()
        {
            Objeto_cpf = new TCPF();
        }
        public string mostra()
        {
            string aux = "";
            return aux += $"Nome do cliente:{nome}, Idade do cliente:{idade}, CPF do cliente:{objeto_cpf.MostraCPF()}"; 
        }
    }
}
