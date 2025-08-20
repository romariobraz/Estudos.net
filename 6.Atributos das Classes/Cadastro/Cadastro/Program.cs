using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Metodos; // 1. Chama o namespace

namespace Cadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa(); // 2 Instância
            //Agora pode sentar o aço.
            pessoa.nome = "Romario";
            pessoa.idade = -1;

            Console.WriteLine($"Meu nome é: {pessoa.nome}");
            Console.WriteLine($"Minha idade é: {pessoa.idade}");
        }
    }
}
