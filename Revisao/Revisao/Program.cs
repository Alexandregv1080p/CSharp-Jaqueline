using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Paciente> listaPacientes = new List<Paciente>();
            Paciente paciente;
            int op;
            do
            {
                
                string nome;
          
                Console.WriteLine("-- Programa de cadastros --");
                Console.WriteLine("-- 1. Criar Paciente --");
                Console.WriteLine("-- 2. Pesquisar endereço de determinado paciente --");
                Console.WriteLine("-- 3. Pesquisar o nome dos pacientes idosos (>60) de uma determinada cidade --");
                Console.WriteLine("-- 4. Sair --");
                Console.WriteLine("-- Digite a opção que deseja --");
                op = int.Parse(Console.ReadLine());
                if(op == 1)
                {
                    Console.Write("Digite o nome do paciente: ");
                    nome = Console.ReadLine();
                    paciente = new Paciente(nome);
                    Console.Write("Digite a idade: ");
                    paciente.Idade = int.Parse(Console.ReadLine());
                    Console.Write("Digite a rua do paciente: ");
                   
                    paciente.End.Rua = Console.ReadLine();
                    Console.Write("Digite o bairro do paciente: ");
                    paciente.End.Bairro = Console.ReadLine();
                    Console.Write("Digite o cep: ");
                    paciente.End.Cep = int.Parse(Console.ReadLine());
                    Console.Write("Digite a cidade: ");
                    paciente.End.Cidade = Console.ReadLine();
                    Console.Write("Digite o numero: ");
                    paciente.End.Numero = int.Parse(Console.ReadLine());
                    Console.Clear();
                    listaPacientes.Add(paciente);
                    Console.WriteLine("Paciente cadastrado com sucesso!");
                    Console.WriteLine("Digite qualquer tecla para continuar...");
                   
                    Console.ReadKey();
                    
                    Console.Clear();
                }
                else if(op == 2)
                {
                    Console.Clear();
                    Console.Write("Digite o nome do paciente");
                    nome = Console.ReadLine();
                    foreach(Paciente p in listaPacientes)
                    {
                        if(p.Nome == nome)
                        {
                            Console.WriteLine($"Nome do Paciente: {p.Nome}, Idade: {p.Idade}");
                            Console.WriteLine(p.End.mostrarEnd());
                        }                                                 
                    }
                    Console.WriteLine("Dado buscado com sucesso!");
                    Console.WriteLine("Digite qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }else if(op == 3)
                {
                    Console.Clear();
                    Console.Write("Digite a cidade do idoso: ");
                    nome = Console.ReadLine();
                    foreach (Paciente p in listaPacientes)
                    {
                        if (p.End.Cidade == nome && p.Idade >= 60)
                        {
                            Console.WriteLine($"Nome do Paciente: {p.Nome}, Idade: {p.Idade}");
                            Console.WriteLine(p.End.mostrarEnd());
                        }
                    }
                    Console.WriteLine("Dado buscado com sucesso!");
                    Console.WriteLine("Digite qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }while (op != 4);
            Console.Clear();
            Console.WriteLine("Fim do programa...");
        }
    }
}
