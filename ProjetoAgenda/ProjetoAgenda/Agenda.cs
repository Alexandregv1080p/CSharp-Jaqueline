using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    internal class Agenda
    {
        private string cidade;
        private string[] fone;
        private string nome;
        private int codigo;

        public Agenda(string cidade, string nome, int codigo)
        {
            this.Cidade = cidade;
            string[] fone = new string[3];
            this.Nome = nome;
            this.Codigo = codigo;
        }

        public string Cidade { get => cidade; set => cidade = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value ;}
        public string[] Fone { get => fone; set => fone = value; }

        string msg = "";
        public string mostra()
        {

            msg+= "Cidade : " + Cidade + ", Codigo : " + Codigo + ", Nome : " + Nome + ", Telefones : ";
            foreach (var f in fone)
            {
                msg += f + "\n";
            }
            return msg;
        }
    }
}
