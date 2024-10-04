using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessoDePagamentoParcelas.Services
{
    internal class PaypalService : IPayment
    {

        private double _fee = 0.02;
        private double _interest = 0.01;
        public PaypalService()
        {

        }
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double Interest(double amount, int months)
        {
            return amount * 0.01 * months;
        }
    }
}
