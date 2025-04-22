namespace ObjectCalisthenics.Rule_5.Before
{
    internal class Customer
    {
        public Address Address { get; set; }

        public Customer(Address address)
        {
            Address = address;
        }
    }
}
