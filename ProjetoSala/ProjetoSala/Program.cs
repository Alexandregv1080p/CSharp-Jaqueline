using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gasolina G1 = new Gasolina("Petrobtras", "Aditivada");
            G1.Preco = 3.65f;
        
            G1.Data.GravarData(30,12,1999);

            Diesel D1 = new Diesel("Shell");
            D1.Preco = 2.78f;
            D1.Data.GravarData(30,11,2032);

            Mostrar(G1);
            Mostrar(D1);
        }
        static void Mostrar(Combustivel c)
        {
            Console.Write(c.MostrarDados());
            if(c is Gasolina)
            {
                Console.WriteLine($"{(c as Gasolina).TipoGasol} ");
                Console.WriteLine($"Preço: {(c as Gasolina).PrecoGasolFunc()} ");
            }
            if(c is Diesel)
            {
                Console.WriteLine($"Preço: {(c as Diesel).PrecoDieselFunc()}");
            }
        }
    }
}
