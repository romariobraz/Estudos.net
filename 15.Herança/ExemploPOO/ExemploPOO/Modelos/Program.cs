using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploPOO.Modelos;

namespace ExemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Romario"); //Tive que passar no construtor, por causa da minha construct
            a1.Idade = 31;
            a1.Nota = 10;
            a1.Apresentar();

            //Aula polimorfismo
            Professor p1 = new Professor("Eduardo"); //Tive que passar no construtor por causa da construct
            p1.Idade = 30;
            p1.Salario = 1000;
            p1.Apresentar();

            //Aula abstração
            //Conta c = new Conta(); //Não é possível instânciar conta diretamente, pois ela é abstrata
            Corrente c = new Corrente();
            c.Creditar(500);
            c.ExibirSaldo();
        }
    }
}
