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
            List<string> modalidades = new List<string>();
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
                    Console.Write("Digite o nome do atleta: ");
                    nome = Console.ReadLine();
                    A = new Atleta(nome);
                    Console.Write("Digite a cidade do atleta: ");
                    A.Cidade = Console.ReadLine();
                    Console.Write("Digite a idade do atleta: ");
                    A.Idade = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o numero de modalidades que deseja gravar: ");
                    int n = int.Parse(Console.ReadLine());
               
                    for(int i = 0; i < n; i++)
                    {
                        Console.Write($"Digite a {i + 1}a modalidade: ");
                        string mod = Console.ReadLine();
                        modalidades.Add(mod);
                    }
                    A.ListaModalidade = modalidades;
                    listaAtletas.Add(A);
                    Console.WriteLine("Atleta adicionado com sucesso!");
                }
                if(op == 2)
                {
                    Console.Write("Digite o nome da modalidade em que deseja procurar atletas: ");
                    nome = Console.ReadLine();
                   
                }
                if(op == 3)
                {
                    Console.WriteLine("Alunos abaixo de 21 anos : ");
                    foreach(Atleta a in listaAtletas)
                    {
                        if(a.Idade < 21)
                        {
                            a.mostrarDados();
                        }
                    }
                }
                if(op == 4)
                {
                    Console.Write("Digite o nome da cidade: ");
                    nome = Console.ReadLine();
                    foreach(Atleta i in listaAtletas)
                    {
                        if(i.Cidade == nome)
                        {
                            i.mostrarDados();
                        }
                    }
                }
                if(op == 5)
                {

                }
            } while (op != 6);
            Console.WriteLine("Programa finalizado!");
            Console.ReadKey();
        }
    }
}
