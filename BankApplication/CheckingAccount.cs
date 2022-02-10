using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
   public class CheckingAccount : Account
    {
        private decimal interestRate;
        public CheckingAccount(decimal initialBalance, decimal interestRate) : base(initialBalance)
        {

        }
    }
}
