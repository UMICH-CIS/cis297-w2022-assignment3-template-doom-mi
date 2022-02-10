using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class SavingsAccount : Account
    {
        private decimal interestRate;

        public SavingsAccount(decimal initialBalance, decimal interestRate) : base(initialBalance)
        {
            this.interestRate = interestRate;
        }

        public decimal CalculateInterest()
        {
            return Balance * interestRate;
        }
    }
    
}
