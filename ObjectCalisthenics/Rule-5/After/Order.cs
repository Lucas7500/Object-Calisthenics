namespace ObjectCalisthenics.Rule_5.After
{
    internal class Order
    {
        public Customer Customer { private get; set; }
        public string CustomerZipCode => Customer.ZipCode;
        public string CustomerCity => Customer.City;

        public Order(Customer customer)
        {
            Customer = customer;
        }
    }
}
