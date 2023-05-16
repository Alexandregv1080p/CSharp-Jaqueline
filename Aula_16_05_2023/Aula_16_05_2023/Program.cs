using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_05_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Professor> listProfessor = new List<Professor>();
            List<Aluno> listAluno = new List<Aluno>();
            Pessoa p1 = null;
            Aluno a1 = null;
            Professor prof1 = null;
            string aux = "";
            int op = 1;
            do
            {
                Console.WriteLine("Cadastro de Professor e Aluno");
                Console.WriteLine("1 - Cadastrar professor");
                Console.WriteLine("2 - Cadastrar aluno");
                Console.WriteLine("3 - Pesquisar aluno pela matricula");
                Console.WriteLine("4 - Pesquisar todos os professores de uma determinada titulação");
                Console.WriteLine("5 - Sair");
                Console.Write("Digite a opção desejada: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        prof1 = new Professor();
                        cadastrar(prof1);
                        listProfessor.Add(prof1);
                        Console.WriteLine("Professor cadastrado com sucesso! ");
                        break;
                    case 2:
                        a1 = new Aluno();
                        cadastrar(a1);
                        listAluno.Add(a1);
                        Console.WriteLine("Aluno cadastrado com sucesso! ");
                        break;
                    case 3:
                        Console.Write("Entre com o número da matrícula: ");
                        aux = Console.ReadLine();
                        foreach(Aluno a in listAluno)
                        {
                            if(a.Matricula == aux)
                            {
                                Console.WriteLine(a.MostrarAluno());
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Entre com a titulação desejada: ");
                        aux = Console.ReadLine();
                        foreach(Professor p in listProfessor)
                        {
                            if(p.Titulacao == aux)
                            {
                                Console.WriteLine(p.MostrarProfessor());
                            }
                        }
                        break;
                }

            }while (op != 5);
        }
        static void cadastrar(Pessoa p)
        {
            string auxCpf;
            do
            {
                Console.Write("Entre com o cpf: ");
                auxCpf = Console.ReadLine();   
            } while (!(p.Tcpf.ValidaCpf(auxCpf)));
            Console.Write("Entre com o nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Entre com a idade: ");
            p.Idade = int.Parse(Console.ReadLine());
            if(p is Professor)
            {
                Console.Write("Entre com a titulação: ");
                (p as Professor).Titulacao = Console.ReadLine();
            }
            if(p is Aluno)
            {
                Console.Write("Entre com a matricula: ");
                (p as Aluno).Matricula = Console.ReadLine();
            }

        }
    }
}
