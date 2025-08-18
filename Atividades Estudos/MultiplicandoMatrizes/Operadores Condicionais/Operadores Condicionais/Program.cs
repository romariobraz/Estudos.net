using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Operador If Else
            /*
            //Definimos a variavel de estoque
            int qEstoque = 10;
            Console.WriteLine("Nós possuimos " + qEstoque + " em estoque, quantas deseja comprar?");

            //Agora vamos receber do usuário quantas unidades ele deseja comprar
            int qCompra = Convert.ToInt32(Console.ReadLine());

            //usando um booleano para validar a venda
            bool valida = qEstoque >= qCompra && qCompra > 0;
            //Não existe uma venda com 0 itens

            //Agora vem a nossa estrutura de decisão
            if (valida) 
            //Poderia usar um booleano para satisfazer ou não essa condição, ou a operação qEstoque >= qCompra
            {
                Console.WriteLine("Venda realizada com sucesso.");
            }
            //Caso o if não seja atendido
            else if (valida == false)
            //else if é um dos meios de se aninhar um if
            {
                Console.WriteLine("Valor para compra precisa ser maior do que 0");
            }
            else
            {
                Console.WriteLine("Não temos a quantidade desejada em estoque.");
            }
            //Posso usar booleanos também para conferir se a condição foi ou não atendida
            Console.WriteLine($"É possível realizar a venda? "+ valida);
            */
            #endregion

            #region switch Case
            /*
            //Verificar se o usuário digitou uma vogal
            Console.WriteLine("Digite uma letra");
            string letra = Console.ReadLine();

            switch (letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("O usuário digitou uma vogal");
                    break;

                default:
                    Console.WriteLine("Oque o usuário digitou, não é uma vogal");
                    break;
            }
            */
            #endregion


        }
    }
}
