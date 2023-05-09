using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listF = new List<Funcionario>();
            List<Docente> listD = new List<Docente>();
            List<Pesquisador> listP = new List<Pesquisador>();
            Funcionario F1 = null;
            Docente D1 = null;
            Pesquisador P1 = null;
            int op = 0;
            do
            {
                Console.WriteLine("Cadastrar 1-Funcionario, 2-Docente, 3-Pesquisador");
                Console.WriteLine("Mostrar 4-Funcionario, 5-Docente, 6-Pesquisador");
                Console.WriteLine("7-Sair");
                Console.Write("Opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        cadastro(F1);
                        listF.Add(F1);
                        break;
                    case 2:
                        cadastro(D1);
                        listD.Add(D1);
                        break;
                    case 3:
                        cadastro(P1);
                        listP.Add(P1);
                        break;
                    case 4:
                        foreach(Funcionario f in listF)
                        {
                            Mostra(f);
                        }
                        break;
                    case 5:
                        foreach(Docente d in listD)
                        {
                            Mostra(d);
                        }
                        break;
                    case 6:
                        foreach(Pesquisador p in listP)
                        {
                            Mostra(p);
                        }
                        break;

                }
            } while (op != 7);
        }
        static void cadastro(Funcionario f) //um Funcionario pode ter acesso a todos os atributos de suas filhas
        {
            string auxCpf;
            do
            {
                Console.Write("CPF: ");
                auxCpf = Console.ReadLine();

            } while (!f.Tcpf.ValidaCpf(auxCpf));
            Console.Write("Entre com o nome: ");
            f.Nome = Console.ReadLine();
            if (f is Docente)
            {
                Console.Write("Formacao: ");
                (f as Docente).Formacao = Console.ReadLine();
            }
            if (f is Pesquisador)
            {
                Console.Write("Area de formação: ");
                (f as Pesquisador).Area = Console.ReadLine();
            }
        }
        static void Mostra(Funcionario f)
        {
            string aux = "";
            aux += $"Nome: {f.Nome},\n";
            if (f is Docente)
            {
                aux += $"Formação: {(f as Docente).Formacao},\n";
            }
            if (f is Pesquisador)
            {
                aux += $"Area de Pesquisa: {(f as Pesquisador).Area}.\n";
            }
            Console.Write(aux);
        }
    }
}
