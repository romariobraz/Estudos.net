using System;
using Operacoes.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Formulas calc = new Formulas();

    //Vamos dar as opções
    inicio:
        Console.WriteLine("\nVamos lá! Digite:\n 1 Para Somar;\n 2 Para subtrair;\n 3 Para multiplicar;\n 4 Para dividir;\n 5 Para fazer uma potência;\n 6 Para calcular o Seno;\n 7 Para Calcular o Coseno;\n 8 Para calcular o tangente;\n 9 Para calcular a Raiz Quadrada;\n 10 Para calcular o IMC\n 11 Para fazer uma sequência de Fibonacci\n ou 0 Para sair.");
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                calc.Somar(0,0);
                goto inicio;
            case 2:
                calc.Subtrair(0, 0);
                goto inicio;
            case 3:
                calc.Multiplicar(0, 0);
                goto inicio;
            case 4:
                calc.Dividir(0, 0);
                goto inicio;
            case 5:
                calc.Potencia(0, 0);
                goto inicio;
            case 6:
                calc.Seno(0);
                goto inicio;
            case 7:
                calc.Coseno(0);
                goto inicio;
            case 8:
                calc.Tangente(0);
                goto inicio;
            case 9:
                calc.RaizQ(0);
                goto inicio;
            case 10:
                calc.Imc(0, 0, 0);
                goto inicio;
            case 11:
                calc.Fibonacci(0, 0, 0);
                goto inicio;
            case 0:
                break;
            default:
                Console.WriteLine("Digite uma opção válida! ou 0 para encerrar.");
            goto inicio;

        }


    }
}