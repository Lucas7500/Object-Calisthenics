namespace ObjectCalisthenics.Rule_5.After
{
    internal class Address
    {
        public string ZipCode { get; set; }
        public string City { get; set; }

        public Address(string zipCode, string city)
        {
            ZipCode = zipCode;
            City = city;
        }
    }
}
