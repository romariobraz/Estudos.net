using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] linhas = File.ReadAllLines("D:/Arquivos/GitHub/Estudos.net/9.Lendo arquivos/ExplorandoArquivos/ExplorandoArquivos/Arquivos/Dados.txt");

            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);

            }
        }
    }
}
