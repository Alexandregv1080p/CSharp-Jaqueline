using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSala
{
    internal class Gasolina: Combustivel
    {
        private string tipoGasol;
        public Gasolina(string empresa, string tipoGasol) :base(empresa)
        {
            this.TipoGasol = tipoGasol;
        }
        public float PrecoGasolFunc() { return Preco * 1.5f; }
        public string TipoGasol { get => tipoGasol; set => tipoGasol = value; }
    }
}
