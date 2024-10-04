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
        public void Tax();
    }
}
