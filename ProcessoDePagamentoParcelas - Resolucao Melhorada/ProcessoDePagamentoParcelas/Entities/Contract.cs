using ProcessoDePagamentoParcelas.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProcessoDePagamentoParcelas.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double ContractValue { get; set; }
        public List<Installment> Installments { get; private set; } 
        PaymentService paymentService { get; set; }

        public Contract(int number, DateTime date, double contractValue)
        {
            Number = number;
            Date = date;
            ContractValue = contractValue;
            Installments = new List<Installment>();
        }

        

        public override string ToString()
        {
            return "Number: "
                + Number
                + ", Date: "
                + Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                + ", Contract value: "
                + ContractValue;                
        }
    }
}
