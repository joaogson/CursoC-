using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProcessoDePagamentoParcelas.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
        public Installment(DateTime date, double amount)
        {
            DueDate = date;
            Amount = amount;
        }

        public override string ToString()
        {
            return "Date: "
                + DueDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                + ", Amount: "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
