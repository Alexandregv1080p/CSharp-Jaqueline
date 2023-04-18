using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class TEndereco
    {
        private string bairro;
        private int cep;
        private string cidade;
        private string estado;
        private int numero;
        private string rua;

        public string Bairro { set => bairro = value; }
        public int Cep { set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Numero { set => numero = value; }
        public string Rua { set => rua = value; }

        public string mostrarEnd()
        {
            string aux = " ";
            return aux = $"Bairro: {bairro}, Cep:{cep}, Estado:{estado}, Cidade:{cidade}, Numero: {numero}, Rua: {rua} ";
        }
    }
}
