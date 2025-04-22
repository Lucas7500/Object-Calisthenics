namespace ObjectCalisthenics.Rule_8.After
{
    internal class Customer
    {
        public string Name { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public Address Address { get; set; }

        public Customer(string name, ContactInfo contactInfo, Address address)
        {
            Name = name;
            ContactInfo = contactInfo;
            Address = address;
        }
    }
}
