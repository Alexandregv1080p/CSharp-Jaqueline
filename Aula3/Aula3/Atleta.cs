using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Atleta
    {
        private string nome;
        private string cidade;
        private int idade;
        private List<string> listaModalidade;

        public Atleta(string nome)
        {
            this.nome = nome;
            listaModalidade = new List<string>();
        }

        public List<string> ListaModalidade { set => listaModalidade = value; }
        

        public int Idade { get => idade; set => idade = value; }
        public string Nome { get { return nome; } }

        public string Cidade { get => cidade; set => cidade = value; }

        public string mostrarDados()
        {
            string aux = $"Nome do atleta: {nome}\nCidade do atleta: {cidade}\nIdade do atleta: {idade}\nModalidades do atleta: ";
            foreach(var item in listaModalidade)
            {
                aux+= item.ToString() + " ";
            }
            return aux;
        }
        public bool mostrarModalidade(string m)
        {
            foreach(string n in listaModalidade)
            {
                if(n == m)
                {
                    return true;
                }
            }
            return false;
            
        }
        
    }
}
