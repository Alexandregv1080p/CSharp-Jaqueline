using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class Pesquisador : Docente
    {
    
        private string area;

        public Pesquisador(string nome, string formacao, string area) : base( formacao,  nome) => this.area = area;
        
        public string MostrarPesquisador()
        {
            string aux = "";
           
            return aux += $"Nome: {area}, Formação:{MostrarFormacao()}, Area: {MostraFuncionario()}";
        }

        
    }
}
