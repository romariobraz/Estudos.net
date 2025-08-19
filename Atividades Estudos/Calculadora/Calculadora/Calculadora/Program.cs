using System;
using Operacoes.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Formulas calc = new Formulas();

        calc.Somar(10, 30);
        calc.Subtrair(30, 10);
        calc.Multiplicar(10, 30);
        calc.Dividir(10, 10);
        calc.Potencia(5, 3);
        calc.Seno(30);
        calc.Coseno(30);
        calc.Tangente(30);
        calc.RaizQ(9);
        calc.Imc(0,0,0);

    }
}