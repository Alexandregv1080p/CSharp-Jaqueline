using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSala
{
    internal class TData
    {
        private int ano;
        private int mes;
        private int dias;

        public void GravarData(int dias, int mes, int ano)
        {
            this.dias = dias;
            this.mes = mes;
            this.ano = ano;
        }
        public string MostrarData()
        {
            string aux = "";
            aux += $"{dias}/{mes}/{ano}";
            return aux;
        }
    }
}
