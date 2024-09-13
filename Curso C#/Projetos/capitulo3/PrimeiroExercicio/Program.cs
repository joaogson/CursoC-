using System;
using System.Security.Cryptography;

namespace PrimeiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            System.Console.WriteLine("Informe os dados da primeira pessoa:");

            a.Nome = Console.ReadLine();
            a.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe os dados da segunda pessoa:");

            b.Nome = Console.ReadLine();
            b.Idade = int.Parse(Console.ReadLine());

            if(a.Idade > b.Idade)
            {
                System.Console.WriteLine($"Pessoa mais velha: {a.Nome}");
            }
            else{
                System.Console.WriteLine($"Pessoa mais velha: {b.Nome}");
            }


        }
    }
    
}