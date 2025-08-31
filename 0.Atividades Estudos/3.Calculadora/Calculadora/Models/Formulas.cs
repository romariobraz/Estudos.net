using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janela.MainWindow;

namespace Operacoes.Models
{
    public class Formulas
    {
        #region Calculos Simples
        //Primeiro vamos para os calculos mais simples + - * / e %
        public double Somar(double x, double y)
        {
            return x + y;
        }

        public double Subtrair(double x, double y)
        {
            return x - y;
        }

        public double Multiplicar(double x, double y)
        {
            return x * y;
        }

        public double Dividir(double x, double y)
        {
            return x / y;
        }
        public double Resto(double x, double y)
        {
            return x % y;
        }
        #endregion

        #region %
        public double Porcentagem(double porcentagem, double numero)
        { 
            return (porcentagem / 100) * numero;
        }


        #endregion

        #region Algebra
        //Vamos para a algebra 
        public double Potencia(double x, double y)
        {
            return Math.Round(Math.Pow(x, y), 4);
        }
        public double RaizQ(double x)
        {
            return Math.Round(Math.Sqrt(x), 4);
        }
        #endregion

        #region Trigonometria
        //Agora para trigonometria Seno, coseno e tangente
        public double Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            return Math.Round(seno, 4);
        }

        public double Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            return Math.Round(coseno, 4);
        }

        public double Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            return Math.Round(tangente, 4);
        }
        #endregion

        #region Extras (IMC e Fobacci)
        //Estes dois são alguns extras de aulas passadas
        public (double valor, string classificacao) Imc(double peso, double altura)
        {
            double valorImc = peso / (altura * altura);
            string classificacao;

            if (valorImc < 18.5) classificacao = "Abaixo do peso";
            else if (valorImc < 24.9) classificacao = "Peso normal";
            else if (valorImc < 29.9) classificacao = "Sobrepeso";
            else if (valorImc < 39.9) classificacao = "Obesidade I";
            else classificacao = "Obesidade mórbida";

            return (Math.Round(valorImc, 2), classificacao);
        }

        public List<double> Fibonacci(int n)
        {
            List<double> seq = new List<double> { 0, 1 };
            for (int i = 2; i <= n; i++)
            {
                seq.Add(seq[i - 1] + seq[i - 2]);
            }
            return seq;
        }
        #endregion

        #region Geometria
        //Agora vamos para formulas geométricas
        public double Raio(double area)
        {
            if (area < 0)
                throw new ArgumentException("Área não pode ser negativa!");
            return Math.Sqrt(area / Math.PI);
        }
        public double AreaQuadrado(double lado)
        {

            return Math.Round(Math.Pow(lado, 2), 4);
        }
        public double AreaRetangulo(double baseRet, double altura)
        {
            return Math.Round(baseRet * altura, 4);
        }
        public double AreaCirculo(double raio)
        {
            return Math.Round(Math.PI * Math.Pow(raio, 2), 4);
        }
        #endregion

        #region Temperaturas
        //Agora vamos trabalhar com conversão de temperaturas
        //C = Celsius, K = Kevin F = Fahrenheit
        public double CF(double c)
        {
            return Math.Round((c * 9.0 / 5.0) + 32, 2);
        }
        public double CK(double c)
        {
            return Math.Round(c + 273.15, 2);
        }
        public double KF(double k)
        {
            return Math.Round((k - 273.15) * 9.0 / 5.0 + 32, 2);
        }
        public double KC(double k)
        {
            return Math.Round(k - 273.15, 2);
        }
        public double FK(double f)
        {
            return Math.Round((f - 32) * 5.0 / 9.0 + 273.15, 2);
        }
        public double FC(double f)
        {
            return Math.Round((f - 32) * 5.0 / 9.0, 2);
        }
        #endregion
    }
}
