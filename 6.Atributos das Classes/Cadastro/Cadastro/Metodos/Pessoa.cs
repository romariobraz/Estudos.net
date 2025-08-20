using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Metodos
{
    internal class Pessoa
    {
        private string _nome;
        public string nome
        {
            get { return _nome.ToUpper(); }
            set { 
                if(value == "") {
                    throw new ArgumentException("Nome vazio!");
                }
                _nome = value;
                }
        }
        public int idade { get; set; }
    }
}
