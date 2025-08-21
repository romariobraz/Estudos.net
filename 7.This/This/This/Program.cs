using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace This
{
    internal class Program
    {
        delegate void Operacao(int n1, int n2);
        static void Main(string[] args)
        {

            Acessar a = new Acessar();
            if (a.Login("abc123"))
            {
                Console.WriteLine("Seja bem vindo, você logou");
                goto etapa2;
            }
            else
            {
                Console.WriteLine("Acesso negado");
                throw new Exception("Senha errada");
            }

        etapa2:
            Acessar m = new Acessar();
            Operacao conta = null; // usei meu delegate
            
            conta += m.Somar;
            conta += m.Subtrair;
            conta += m.Multiplicar;
            conta += m.Dividir;
            conta(10, 2); //Só agora dei valores
            Console.WriteLine("Segunda etapa");
            conta -= m.Dividir;//exclui essa com uma operação
            conta -= m.Subtrair;//exclui essa com uma operação
            conta(20, 4);//novos valores para minha variável.

            Console.ReadKey();
        }

    }
}
