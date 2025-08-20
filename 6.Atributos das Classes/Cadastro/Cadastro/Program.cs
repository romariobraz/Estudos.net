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
            pessoa.Nome = "Romario";
            pessoa.Idade = 31;
            pessoa.Sobrenome = "Rocha";

            Console.WriteLine($"Meu nome é: {pessoa.Nome}");
            Console.WriteLine($"Meu sobrenome é: {pessoa.Sobrenome}");
            Console.WriteLine($"Meu nome completo é: {pessoa.NomeCompleto}");
            Console.WriteLine($"Minha idade é: {pessoa.Idade}");
        }
    }
}
