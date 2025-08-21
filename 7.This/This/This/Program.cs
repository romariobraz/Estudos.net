﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            //Agora vamos para a aula de construtores

            Pessoa p1 = new Pessoa();

            Console.WriteLine("Meu nome é: "+ p1.nome);
            Console.WriteLine("Meu sobrenome é: "+ p1.sobrenome);
            Console.WriteLine("Eu nasci do ano de: "+ p1.anoNascimento);
            Console.WriteLine($"Atualmente tenho {p1.idade} anos.\n");

            Pessoa p2 = new Pessoa("Amanda", "Almeida", 2007);
            Console.WriteLine("Meu nome é: " + p2.nome);
            Console.WriteLine("Meu sobrenome é: " + p2.sobrenome);
            Console.WriteLine("Eu nasci do ano de: " + p2.anoNascimento);
            Console.WriteLine($"Atualmente tenho {p2.idade} anos.\n");

            Pessoa p3 = new Pessoa("Ricardo", "Santos");
            Console.WriteLine("Meu nome é: " + p3.nome);
            Console.WriteLine("Meu sobrenome é: " + p3.sobrenome);
            Console.WriteLine("Eu nasci do ano de: " + p3.anoNascimento);
            Console.WriteLine($"Atualmente tenho {p3.idade} anos.\n");

            Console.ReadKey();
        }

    }
}
