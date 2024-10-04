using System;
using System.ComponentModel;
using System.Globalization;
using ProcessoDePagamentoParcelas.Entities;

namespace ProcessoDePagamentoParcelas.Services
{
    class PaymentService
    {
        public int NumberOfInstallments { get; set; }
        public Contract Contract { get; set; }

        public PaymentService(Contract contract, int numberOfInstallments)
        {
            NumberOfInstallments = numberOfInstallments;
            Contract = contract;
            
        }

        public void Tax()
        {

            for (int i=1; i<= NumberOfInstallments; i++)
            {
                double valuePerInstallment = (Contract.ContractValue / NumberOfInstallments) + (Contract.ContractValue / NumberOfInstallments) * (0.01 * i);
                double valueWithAllTaxes = valuePerInstallment + valuePerInstallment * 0.02;               
                
                Contract.Installments.Add(new Installment(Contract.Date.AddMonths(i), valueWithAllTaxes));
                
            }
        }

        public void GetInstallments()
        {
            foreach (var installment in Contract.Installments)
                Console.WriteLine("Quota: " + installment.Amount + ", Date: " + installment.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
        }
    }
}
