namespace ObjectCalisthenics.Rule_8.Before
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Customer(string name, string email, string phoneNumber, string street, string number, string complement, string city, string state, string zipCode)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Street = street;
            Number = number;
            Complement = complement;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
