using System;
using System.ComponentModel;
using System.Globalization;
using ProcessoDePagamentoParcelas.Entities;

namespace ProcessoDePagamentoParcelas.Services
{
    class PaymentService
    {
        private IPayment _payment { get; set; }

        public PaymentService(IPayment payment)
        {
            _payment = payment;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double BasicQuota = contract.ContractValue / months;


            for (int i=1; i<=months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);

                double updateQuota = BasicQuota + _payment.Interest(BasicQuota, i);

                double fullQuota = updateQuota + _payment.PaymentFee(updateQuota); 

                contract.Installments.Add(new Installment(date, fullQuota));
            }
        }

    }
}
