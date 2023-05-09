using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Pesquisador : Docente
    {
    
        private string area;

        public string Area { get { return area; } set { area = value; } }
        

        public string MostrarPesquisador()
        {
            string aux = "";
           
            return aux += $"Nome: {Area}, Formação:{MostrarFormacao()}, Area: {MostraFuncionario()}";
        }

        
    }
}
