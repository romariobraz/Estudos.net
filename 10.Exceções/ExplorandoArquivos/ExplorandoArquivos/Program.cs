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

            try { //Tenta

                string[] linhas = File.ReadAllLines("D:\\Arquivos\\GitHub\\Estudos.net\\10.Exceções\\ExplorandoArquivos\\ExplorandoArquivos\\Arquivos\\Dados.txt");
                
                
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);

                }
            }

            catch(Exception ex) //estamos capturando o errro da excessão
            { 
                      Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}"); //e escrevendo ela
            }


        }
    }
}
