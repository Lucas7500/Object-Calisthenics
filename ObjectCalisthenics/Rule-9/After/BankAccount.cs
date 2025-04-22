namespace ObjectCalisthenics.Rule_9.After
{
    internal class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            if (!CanWithdraw(amount))
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            Balance -= amount;
        }

        private bool CanWithdraw(decimal amount) => Balance >= amount;
    }
}
