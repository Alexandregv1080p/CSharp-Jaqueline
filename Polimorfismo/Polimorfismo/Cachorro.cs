using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Cachorro: Animal
    {
        public override string QuemSou()
        {
            return $"{base.QuemSou()} Cachorro";
        }
    }
}
