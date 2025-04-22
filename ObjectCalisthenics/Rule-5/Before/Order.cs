namespace ObjectCalisthenics.Rule_5.Before
{
    internal class Order
    {
        public Customer Customer { get; set; }

        public Order(Customer customer)
        {
            Customer = customer;
        }
    }
}
