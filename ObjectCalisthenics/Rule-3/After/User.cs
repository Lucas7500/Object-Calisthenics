namespace ObjectCalisthenics.Rule_3.After
{
    internal class User
    {
        public string Name { get; set; }
        public Email Email { get; set; }
        public Cpf Cpf { get; set; }

        public User(string name, Email email, Cpf cpf)
        {
            if (!IsValidName(name))
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            Name = name;
            Email = email;
            Cpf = cpf;
        }

        private static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }
    }
}
