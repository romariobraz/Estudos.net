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
        private int _idade;
        public string Nome
        {
            get => _nome; //Isto é uma body expression
            //{ return _nome.ToUpper(); }
            set { 
                if(value == "") {
                    //Caso o valor seja vazio, o programa irá encerrar nesta excessão
                    throw new ArgumentException("Nome vazio!");
                }
                _nome = value;
                }
        }
        public int Idade { 

            get => _idade;
            set
            {
                if (value < 0) {
                    throw new ArgumentException("A idade não pode ser menor do que 0");
                }
                _idade = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    }
}
