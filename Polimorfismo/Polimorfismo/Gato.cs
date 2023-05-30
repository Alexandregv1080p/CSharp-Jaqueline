using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Gato:Animal
    {
        public override string QuemSou()
        {
            return $"{base.QuemSou()} Gato";
        }
        
    }
}
