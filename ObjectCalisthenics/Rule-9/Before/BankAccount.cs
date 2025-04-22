namespace ObjectCalisthenics.Rule_9.Before
{
    internal class BankAccount
    {
        public decimal Balance { get; set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }
    }
}
