namespace ObjectCalisthenics.Rule_9.After
{
    internal class PaymentService
    {
        // Using "Tell, Don't Ask" Principle
        public void ProcessWithdrawal(BankAccount account, decimal amount)
        {
            account.Withdraw(amount);
        }
    }
}
