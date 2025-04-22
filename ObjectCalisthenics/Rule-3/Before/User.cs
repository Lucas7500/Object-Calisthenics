using System.Text.RegularExpressions;

namespace ObjectCalisthenics.Rule_3.Before
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public User(string name, string email, string cpf)
        {
            if (!IsValidName(name))
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            if (!IsValidEmail(email))
            {
                throw new ArgumentException("Invalid email format.");
            }

            if (!IsValidCpf(cpf))
            {
                throw new ArgumentException("Invalid CPF format.");
            }

            Name = name;
            Email = email;
            Cpf = cpf;
        }

        private static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

        private static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private static bool IsValidCpf(string cpf)
        {
            return Regex.IsMatch(cpf, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
        }
    }
}
