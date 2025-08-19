using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacoes.Models
{
    public class Formulas
    {
        public void Somar(int x, int y)
            {
                Console.WriteLine($"{x} + {y} = {x + y}");
            }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
            
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O Seno de {angulo} = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O Coseno de {angulo} = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tan = Math.Tan(radiano);
            Console.WriteLine($"O Tangente de {angulo} = {Math.Round(tan, 4)}");
        }

        public void RaizQ( double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é {raiz}");
        }

        public void Imc(double peso, double altura, double valorImc)
        {
            Console.WriteLine("Informe o peso em KG: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            valorImc = peso / (altura * altura);

            Console.WriteLine($"Seu IMC é: {valorImc}");

            if( valorImc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if( valorImc >= 18.5 &&  valorImc < 24.9)
            {
                Console.WriteLine("Seu peso está normal");
            }
            else if (valorImc >= 25 && valorImc < 29.9)
            {
                Console.WriteLine("Você está com sobrepeso");
            }
            else if (valorImc >= 30 && valorImc < 39.9)
            {
                Console.WriteLine("Você está com obesidade I");
            }
            else
            {
                Console.WriteLine("Você está com obesidade mórbida, cuide de sua saúde.");
            }

        }

    }
}
