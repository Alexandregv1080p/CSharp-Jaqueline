using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Agenda> agenda = new List<Agenda>();
            Agenda A;
            char ok = 's';
            do
            {
                
                Console.Write("Digite seu nome : ");
                string nome = Console.ReadLine();
                Console.Write("Digite sua cidade : ");
                string cidade = Console.ReadLine();
                Console.Write("Digite seu codigo : ");
                int codigo = int.Parse(Console.ReadLine());
                string[] fones = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Entre com o " + (i+1) + "o numero ");
                    fones[i] = Console.ReadLine();
                }
                A = new Agenda(cidade,nome,codigo);
                A.Fone = fones;
                agenda.Add(A);
                Console.WriteLine("Continuar? (s/n)");
                ok = char.Parse(Console.ReadLine());
            } while (ok == 's');
            foreach(Agenda ag in agenda)
            {
                Console.WriteLine(ag.mostra());
            }
            Console.ReadKey();
        }
    }
}
