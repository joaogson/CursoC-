using System;

namespace SegundaExercicio{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();
            double media;

            System.Console.WriteLine("Informe os dados do primeiros funcionario");
            a.Nome = Console.ReadLine();
            a.Salario = double.Parse(Console.ReadLine());
    
            System.Console.WriteLine("Informe os dados do primeiros funcionario");
            b.Nome = Console.ReadLine();
            b.Salario = double.Parse(Console.ReadLine());

            media = (a.Salario + b.Salario)/2;

            Console.WriteLine($"media dos salários: {media}");
        }
    }
}