using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
   public class CheckingAccount : Account
    {
        public decimal feeCharge;

        public CheckingAccount(decimal initialBalance, decimal feeCharge) : base(initialBalance)
        {
            this.feeCharge = feeCharge;
        }

        public void Credit(decimal money)
        {
            if ((Balance - feeCharge) + money < 0)
            {
                Console.WriteLine("Credit will not cover fee charge. Please deposit additional funds");
            }

            else
            {
                Balance = (Balance - feeCharge) + money;
            }
        }

        public void Debit(decimal money)
        {
            if(base.Debit(money))
            {
                Balance -= feeCharge;
            }
        }
    }
}
