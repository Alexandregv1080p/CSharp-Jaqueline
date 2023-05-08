using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medico m1 = new Medico();
            cadastroPessoa(m1);
            Console.Write("Crm: ");
            m1.Crm = Console.ReadLine();
            Console.Write("Especialidade: ");
            m1.Especialidade = Console.ReadLine();
            Console.WriteLine(m1.MostrarMedico());

            Paciente p1 = new Paciente();
            cadastroPessoa(p1);
            Console.Write("Plano: ");
            p1.Plano = Console.ReadLine();
            Console.WriteLine(p1.MostrarPaciente());
        }
        static void cadastroPessoa(Pessoa p)
        {
            Console.Write("Cpf: ");
            p.Cpf = Console.ReadLine();
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p.Idade = int.Parse(Console.ReadLine());
        }
    }
}
