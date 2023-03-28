using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoalist = new List<Pessoa>();
            char c = 's';
            int i = 0;
            Pessoa P;
            do
            {
                P = new Pessoa();
                Console.Write("Entre com o nome : ");
                P.Nome = Console.ReadLine();
                Console.Write("Entre com a idade : ");
                P.Idade = int.Parse(Console.ReadLine());
                pessoalist.Add(P);
                Console.WriteLine("Adicionar mais?");
                c = char.Parse(Console.ReadLine());
            } while (c == 's');

            Console.WriteLine("Objetos cadastrados : ");
            foreach(Pessoa pessoa in pessoalist){
                Console.WriteLine(pessoa.Mostra());
            }
            Console.ReadKey();
        }
    }
}
