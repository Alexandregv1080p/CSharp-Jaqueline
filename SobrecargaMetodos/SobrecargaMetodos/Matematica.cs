using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodos
{
    internal class Matematica
    {
        public string Soma(double a, double b)
        {
            return $"Soma dos dois números double: {a + b}";
        }
        public string Soma(int a, int b)
        {
            return $"Soma dos dois números inteiros: {a + b}";
        }
        public string Soma(int a, int b, int c)
        {
            return $"Soma dos três números inteiros: {a + b + c}";
        }
    }
}
