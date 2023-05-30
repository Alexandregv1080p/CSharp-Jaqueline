using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato();
            gato.Nome = "Alcino";
            Console.WriteLine(gato.QuemSou());

            Animal cachorro = new Cachorro();
            cachorro.Nome = "Rusty";
            Console.WriteLine(cachorro.QuemSou());

            Animal animal = new Animal();
            animal.Nome = "Muranga";
            cachorro.Nome = "Rusty";
            Console.WriteLine(animal.QuemSou());
        }
    }
}
