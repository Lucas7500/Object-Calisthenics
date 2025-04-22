namespace ObjectCalisthenics.Rule_8.After
{
    internal record Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address(string street, string number, string complement, string city, string state, string zipCode)
        {
            Street = street;
            Number = number;
            Complement = complement;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
