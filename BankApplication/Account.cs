using System;

namespace BankApplication
{
    /// <summary>
    /// Methods and objects for base Account class
    /// </summary>
    public class Account
    {
        private decimal accountBalance;

        // Get and set for accountBalance
        public decimal Balance
        { get { return accountBalance; }
          set { accountBalance = value; }
        }

        /// <summary>
        /// Constructor to set up initial account balance
        /// </summary>
        /// <param name="initialBalance"></param>
        public Account(decimal initialBalance)
        {
            accountBalance = initialBalance;
            if(accountBalance <= 0)
            {
                throw new ArgumentException(paramName: nameof(accountBalance), message: "Account balance cannot be at a zero/negative balance.");
            }

        }

        /// <summary>
        /// Adds money value from base account
        /// </summary>
        /// <param name="money"></param>
        public void Credit(decimal money)
        {
            accountBalance += money;
        }

        /// <summary>
        /// Checks if removing money from balance would overdraw account. If not, removes money value from account
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public bool Debit(decimal money)
        {
            if(accountBalance - money < 0)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                return false;
            }

            else
            {
                accountBalance -= money;
                return true;
            }
        }
    }
}
