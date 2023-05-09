using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Funcionario
    {

        private string nome;
        private TCPF tcpf;
        public string Nome { get => nome; set => nome = value; }
        internal TCPF Tcpf { get => tcpf; set => tcpf = value; }

        public string MostraFuncionario()
        {
            string aux = "";
            return aux += $"{Nome}";
        }
        public Funcionario()
        {
            tcpf = new TCPF();
        }
    }
}
