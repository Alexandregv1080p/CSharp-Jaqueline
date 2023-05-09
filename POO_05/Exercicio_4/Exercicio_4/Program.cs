using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            cadastro(f1);
            Docente docente = new Docente();
            cadastro(docente);
            Pesquisador pesquisador = new Pesquisador();
            cadastro(pesquisador);

            Mostra(f1);
            Mostra(docente);
            Mostra(pesquisador);
        }
        static void cadastro(Funcionario f) //um Funcionario pode ter acesso a todos os atributos de suas filhas
        {
            string auxCpf;
            do
            {
                Console.Write("CPF: ");
                auxCpf = Console.ReadLine();

            }while(!f.Tcpf.ValidaCpf(auxCpf));
            Console.Write("Entre com o nome: ");
            f.Nome = Console.ReadLine();
            if(f is Docente)
            {
                Console.Write("Formacao: ");
                (f as Docente).Formacao = Console.ReadLine();
            }
            if(f is Pesquisador)
            {
                Console.Write("Area de formação: ");
                (f as Pesquisador).Area = Console.ReadLine();
            }
        }
        static void Mostra(Funcionario f)
        {
            string aux = "";
            aux += $"Nome: {f.Nome},\n";
            if(f is Docente)
            {               
                aux += $"Formação: {(f as Docente).Formacao},\n";                             
            }
            if( f is Pesquisador)
            {
                aux += $"Area de Pesquisa: {(f as Pesquisador).Area}.";
            }
            Console.Write(aux);
        }
    }
}
