using System;

namespace BankApplication
{
    /// <summary>
    /// Methods and objects for CheckingAccount class
    /// </summary>
   public class CheckingAccount : Account
    {
        public decimal feeCharge;

        /// <summary>
        /// Constructor that sets the fee charge and initial account balance
        /// </summary>
        /// <param name="initialBalance"></param>
        /// <param name="feeCharge"></param>
        public CheckingAccount(decimal initialBalance, decimal feeCharge) : base(initialBalance)
        {
            this.feeCharge = feeCharge;
        }

        /// <summary>
        /// Overrides the Credit method from base Account class. Checks if money will cover fee transaction, then credits the account or denies
        /// </summary>
        /// <param name="money"></param>
        public new void Credit(decimal money)
        {
            if ((Balance - feeCharge) + money < 0)
            {
                Console.WriteLine("Credit will not cover fee charge. Please deposit additional funds");
            }

            else
            {
                Balance += (feeCharge + money);
            }
        }

        /// <summary>
        /// Overrides the Debit method from base Account class. Deducts fee and transaction money from account
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public new bool Debit(decimal money)
        {
            if(base.Debit(money))
            {
                Balance -= (feeCharge + money);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
