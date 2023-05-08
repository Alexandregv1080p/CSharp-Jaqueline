using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_05_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cpf = "";
            string nome = "";
            int idade = 0;
            cadastroPessoa(ref cpf, ref nome, ref idade);
            Console.Write("CRM: ");
            string crm = Console.ReadLine();
            Console.Write("Especialidade:");
            string especialidade = Console.ReadLine();
            Medico m1 = new Medico(nome, idade, cpf, crm, especialidade);
            Console.WriteLine(m1.MostrarMedico());

            cadastroPessoa(ref cpf, ref nome, ref idade);
            Console.Write("Plano: ");
            string plano = Console.ReadLine();
            Paciente p1 = new Paciente(nome, idade, cpf,plano);
            Console.WriteLine(p1.MostrarPaciente());

        }
        static void cadastroPessoa(ref string cpf, ref string nome,ref int idade)
        {
            Console.Write("Cpf: ");
            cpf = Console.ReadLine();
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());
            
            
        }
    }
}
