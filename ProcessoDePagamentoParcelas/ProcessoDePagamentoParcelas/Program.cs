using System;
using ProcessoDePagamentoParcelas.Entities;
using ProcessoDePagamentoParcelas.Services;

namespace ProcessoDePagamentoParcelas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);

            Console.WriteLine("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            PaymentService payment = new PaymentService(contract, installments);

            Console.WriteLine(contract);           

            payment.GetInstallments();
        }
    }
}