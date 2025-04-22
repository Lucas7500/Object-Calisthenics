using System.Text.RegularExpressions;

namespace ObjectCalisthenics.Rule_3.After
{
    internal readonly record struct Email
    {
        public string Value { get; }

        public Email(string email)
        {
            if (!IsValid(email))
            {
                throw new ArgumentException("Invalid email format.");
            }

            Value = email;
        }

        public static bool IsValid(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
