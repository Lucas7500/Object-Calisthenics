using System.Text.RegularExpressions;

namespace ObjectCalisthenics.Rule_3.After
{
    internal readonly record struct Cpf
    {
        public string Value { get; }

        public Cpf(string cpf)
        {
            if (!IsValid(cpf))
            {
                throw new ArgumentException("Invalid CPF format.");
            }

            Value = cpf;
        }

        public static bool IsValid(string cpf)
        {
            return Regex.IsMatch(cpf, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
        }
    }
}
