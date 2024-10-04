using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProcessoDePagamentoParcelas.Services
{
    interface IPayment
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
