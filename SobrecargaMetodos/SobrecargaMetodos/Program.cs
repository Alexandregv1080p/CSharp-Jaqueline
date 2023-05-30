using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematica matematica = new Matematica();
            Console.WriteLine(matematica.Soma(1, 2));
            Console.WriteLine(matematica.Soma(1.5, 2.8));
            Console.WriteLine(matematica.Soma(1, 2,3));


            Agenda agenda = new Agenda();
            Agenda agenda1 = new Agenda("Jaqueline");
            Agenda agenda2 = new Agenda("Roberto",25);
            Agenda agenda3 = new Agenda("Claudio","Carmo do Rio Claro", 45);
            Console.WriteLine(agenda.Mostra());
            Console.WriteLine(agenda1.Mostra());
            Console.WriteLine(agenda2.Mostra());
            Console.WriteLine(agenda3.Mostra());
        }
}
    }
