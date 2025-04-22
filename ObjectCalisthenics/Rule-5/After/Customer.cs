namespace ObjectCalisthenics.Rule_5.After
{
    internal class Customer
    {
        public Address Address { private get; set; }
        public string ZipCode => Address.ZipCode;
        public string City => Address.City;

        public Customer(Address address)
        {
            Address = address;
        }
    }
}
