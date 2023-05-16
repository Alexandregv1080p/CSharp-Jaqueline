using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_05_2023
{
    internal class Pessoa
    {
        private TCPF tcpf = new TCPF();
        private int idade;
        private string nome;

        public int Idade { set => idade = value; }
        public string Nome { set => nome = value; }
        public TCPF Tcpf { get => tcpf; set => tcpf = value; }

        public string MostrarPessoa()
        {
            string aux = "";
            return aux += $"Nome: {nome}, Idade: {idade}, CPF: {tcpf.MostraCPF()}";
        }
    }
}
