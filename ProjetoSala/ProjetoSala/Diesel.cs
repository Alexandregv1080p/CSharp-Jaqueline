using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSala
{
    internal class Diesel:Combustivel
    {
        public Diesel(string fornecedor) :base(fornecedor)
        {
            
        }

        public float PrecoDieselFunc()
        {
            return Preco * 0.20f;
        }
    }
}
