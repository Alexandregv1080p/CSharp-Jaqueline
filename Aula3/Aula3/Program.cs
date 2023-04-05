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
            List<Atleta> listaAtletas = new List<Atleta>();
            HashSet<string> modalidades2 = new HashSet<string>();
            Atleta A;
            string nome;
            int op;
            do
            {
                Console.WriteLine("---Registro de atletas---");
                Console.WriteLine("1 - Criar atleta");
                Console.WriteLine("2 - Pesquisar o nome dos atletas por modalidade");
                Console.WriteLine("3 - Mostrar o nome dos atletas menores de 21 anos");
                Console.WriteLine("4 - Mostrar os atletas de uma determinada cidade");
                Console.WriteLine("5 - Mostrar o numero de atletas de cada modalidade");
                Console.WriteLine("6 - Sair");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.Clear();

                    Console.Write("Digite o nome do atleta: ");

                    nome = Console.ReadLine();
                    A = new Atleta(nome);
                    Console.Write("Digite a cidade do atleta: ");

                    A.Cidade = Console.ReadLine();
                    Console.Write("Digite a idade do atleta: ");
                    A.Idade = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o numero de modalidades que deseja
                    

                    gravar: ");
                    int n = int.Parse(Console.ReadLine());
                    List<string> modalidades = new List<string>();
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Digite a {i + 1}a modalidade: ");
                        string mod = Console.ReadLine();
                        modalidades.Add(mod);
                        modalidades2.Add(mod);
                    }

                    A.ListaModalidade = modalidades;
                    listaAtletas.Add(A);
                    modalidades2.Distinct().ToList();
                    Console.Clear();
                    Console.WriteLine("Atleta adicionado com sucesso!");

                    Console.WriteLine("Aperte enter para continuar....");

                    Console.ReadKey();
                    Console.Clear();
                }
                if (op == 2)
                {
                    Console.Clear();

                    Console.Write("Digite o nome da modalidade em que deseja procurar atletas: ");
                    nome = Console.ReadLine();
                    foreach (Atleta a in listaAtletas)
                    {
                        Console.WriteLine(a.mostrarModalidade(nome));
                        if (a.mostrarModalidade(nome) == true)

                        {
                            Console.WriteLine(a.mostrarDados());
                        }
                    }
                    Console.WriteLine("Aperte enter para continuar....");

                    Console.ReadKey();
                    Console.Clear();

                }
                if (op == 3)
                {
                    Console.Clear();

                    Console.WriteLine("Alunos abaixo de 21 anos : ");
                    foreach (Atleta a in listaAtletas)

                    {
                        if (a.Idade < 21)

                        {

                            Console.WriteLine(a.mostrarDados());
                        }
                    }

                    Console.WriteLine("Aperte enter para continuar....");
                    Console.ReadKey();
                    Console.Clear();

                }
                if (op == 4)
                {
                    Console.Clear();

                    Console.WriteLine("Alunos cadastrados na cidade");
                    Console.Write("Digite o nome da cidade: ");
                    nome = Console.ReadLine();
                    foreach (Atleta i in listaAtletas)

                    {
                        if (i.Cidade == nome)

                        {

                            Console.WriteLine(i.mostrarDados());
                        }
                    }

                    Console.WriteLine("Aperte enter para continuar....");
                    Console.ReadKey();
                    Console.Clear();

                }
                if (op == 5)//nao consegui fazer a 5

                {
                    Console.Clear();

                    Console.WriteLine("Numero de atletas registrados em cada
                    

                    modalidade: ");
                    int v = 1;

                    foreach (Atleta a in listaAtletas)

                    {
                        foreach (string i in modalidades2)
                        {
                            if (a.mostrarModalidade(i) == true)
                            {
                                Console.WriteLine(i + ":" + v);
                                v++;
                            }
                        }
                    }
                }
            } while (op != 6);
            Console.Clear();
            Console.WriteLine("Programa finalizado!");
            Console.ReadKey();
        }
    }
}
