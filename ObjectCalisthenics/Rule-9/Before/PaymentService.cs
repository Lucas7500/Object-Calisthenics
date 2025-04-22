namespace ObjectCalisthenics.Rule_9.Before
{
    internal class PaymentService
    {
        public void ProcessWithdrawal(BankAccount account, decimal amount)
        {
            if (account.Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            
            account.Balance -= amount;
        }
    }
}
