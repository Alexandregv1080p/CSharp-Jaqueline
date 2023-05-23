using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSala
{
    internal class Combustivel
    {
        private float preco;
        private TData data;
        private string fornecedor;

        public float Preco { get => preco; set => preco = value; }
        internal TData Data { get => data; set => data = value; }
        
        public Combustivel(string fornecedor)
        {
            this.fornecedor = fornecedor;
            data = new TData();
        }

        public string MostrarDados()
        {
            string aux = "";
            aux += $"{fornecedor} {preco}, {data.MostrarData()}";
            return aux;
        }
    }
}
