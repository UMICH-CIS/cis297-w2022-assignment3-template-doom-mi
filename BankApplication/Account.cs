using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Account
    {
        private decimal accountBalance;

        public decimal Balance { get { return accountBalance; } }

        public Account(decimal initialBalance)
        {
            accountBalance = initialBalance;
            if(accountBalance <= 0)
            {
                throw new ArgumentException(paramName: nameof(accountBalance), message: "Account balance cannot be at a zero/negative balance.");
            }

        }

        public void Credit(decimal money)
        {
            accountBalance += money;
        }

        public void Debit(decimal money)
        {
            if(accountBalance - money < 0)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
            }

            else
            {
                accountBalance -= money;
            }
        }
    }
}
