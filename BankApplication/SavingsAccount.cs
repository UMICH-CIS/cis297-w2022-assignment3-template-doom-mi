namespace BankApplication
{
    /// <summary>
    /// Methods and objects for SavingsAccount class
    /// </summary>
    public class SavingsAccount : Account
    {
        private decimal interestRate;

        /// <summary>
        /// Constructor to set up initial account balance and interest rate for savings
        /// </summary>
        /// <param name="initialBalance"></param>
        /// <param name="interestRate"></param>
        public SavingsAccount(decimal initialBalance, decimal interestRate) : base(initialBalance)
        {
            this.interestRate = interestRate;
        }

        /// <summary>
        /// Calculates the interest rate from the remaining account balance
        /// </summary>
        /// <returns></returns>
        public decimal CalculateInterest()
        {
            return Balance * interestRate;
        }
    }
    
}
