﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetores Unidimensional
            int[] numeros = new int[5];
            //Nesta ocasião, declaramos um vetor com "[]", e ele possui [5] posições, o new está inicializando o vetor
            numeros[0] = 10;
            //Aloquei um valor na posição 0
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;
            //Pronto, todas as 5 posições estão alocadas.

            int resultado = numeros[0] + numeros[1];
            Console.WriteLine("A soma de dois elementos do nosso vetor é: "+ resultado);
            //caso tente declarar um valor para uma posição fora do vetor, irá gerar um erro.
            //ex numeros[5] = 60

            string[] nomes = { "Romario", "Braz", "da", "Rocha" };
            //Outra maneira de declarar meu vetor e atribuir valores.
            Console.WriteLine(nomes[0]);
            #endregion

            #region Vetor bidimensional
            int[,] numerosbi = new int[2,2];
            //Iniciei um vetor bi dimensinal, como uma tabela 2x2
            numerosbi[0,0] = 1;
            numerosbi[1,0] = 2;
            numerosbi[0,1] = 3;
            numerosbi[1,1] = 4;
            Console.WriteLine("Valor do campo 0 0: "+ numerosbi[0,0]);
            Console.WriteLine("Valor do campo 1 0: "+ numerosbi[1,0]);
            Console.WriteLine("Valor do campo 0 1: "+ numerosbi[0,1]);
            Console.WriteLine("Valor do campo 1 1: "+ numerosbi[1,1]);
            int resultadobi = numerosbi[0,0] + numerosbi[1,1];
            Console.WriteLine("A soma do campo 00 + 11 é: "+ resultadobi);

            string[,] nomesbi =
            {
                { "Romario ", "Braz " },
                {"da ", "Rocha" }

            };
            Console.WriteLine(nomesbi[0,0]);

            #endregion

        }
    }
}
