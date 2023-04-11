using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Cliente cliente1 = new Cliente();
            cliente1.Nome = "Livia";
            cliente1.Idade = 20;
            Console.WriteLine(cliente1.Objeto_cpf.ValidaCpf("99999999999") ? "CPF válido" : "CPF inválido");
            Console.WriteLine(cliente1.mostra());
            */
            List<Cliente> clientes = new List<Cliente>();
            int op;
            do
            {
                string nome;
                Cliente cliente = new Cliente();
                Console.WriteLine("--Cadastro de clientes--");
                Console.WriteLine("1 - Criar cliente");
                Console.WriteLine("2 - Mostrar determinado cliente pelo nome");
                Console.WriteLine("3 - Mostrar clientes maiores de 60 anos");
                Console.WriteLine("4 - Sair");
                Console.Write("Entre com a opção desejada: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                if (op == 1)
                {
                    Console.WriteLine("Entre com o nome do cliente que deseja: ");
                    cliente.Nome = Console.ReadLine();
                    Console.Write("Entre com a idade: ");
                    cliente.Idade = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o cpf do cliente: ");
                    string cpf = Console.ReadLine();
                    Console.WriteLine("CPF válido : " + (cliente.Objeto_cpf.ValidaCpf(cpf) ? "Válido" : "Não válido"));
                    clientes.Add(cliente);
                    Console.WriteLine("Cliente adicionado com sucesso!");
                    Console.WriteLine("Digite qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o nome do cliente que deseja buscar: ");
                    nome = Console.ReadLine();
                    foreach (Cliente cli in clientes)
                    {
                        if (cli.Nome.Equals(nome))
                        {
                            cli.mostra();
                        }
                    }
                    Console.WriteLine("Digite qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Mostrando clientes acima de 60 anos : ");
                    foreach (Cliente cli in clientes)
                    {
                        if (cli.Idade > 60)
                        {
                            cli.mostra();
                        }
                    }
                    Console.WriteLine("Digite qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (op != 4);

        }
    }
    }

