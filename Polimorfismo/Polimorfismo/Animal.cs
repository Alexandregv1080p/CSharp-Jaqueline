using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Animal
    {
        string nome;
        public string Nome { get => nome; set => nome = value; }
        virtual public string QuemSou()
        {
            return $"Meu nome é {Nome}, sou um animal, do tipo: ";
        }
    }
}
