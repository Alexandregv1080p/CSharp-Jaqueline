using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Formação: ");
            string formacao = Console.ReadLine();
            Console.Write("Área de pesquisa: ");
            string area = Console.ReadLine();

            Pesquisador p = new Pesquisador(nome, formacao, area);
            Console.WriteLine(p.MostrarPesquisador());

        }
        
    }
}
