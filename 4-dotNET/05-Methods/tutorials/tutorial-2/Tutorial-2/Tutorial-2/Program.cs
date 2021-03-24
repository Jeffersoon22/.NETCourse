using System;
using System.Text;
namespace Tutorial_2
{
    class Program
    {
        private const int PasswordMinLength = 8;
        private const int PasswordDigitsAmount = 2;
        private const string PasswordLengthErrorMessage = "A password must have at least 8 characters.\n";
        private const string PasswordFormatErrorMessage = "A password must consist of only letters and digits.\n";
        private const string PasswordDigitsErrorMessage = "A password must contain at least two digits.\n";
        static void Main(string[] args)
        {
            Console.Write("Input a password: ");
            string password = Console.ReadLine();
            bool isPasswordValid = IsPasswordValid(password, out string errors);
            Console.WriteLine($"Password is valid: {isPasswordValid}");
            Console.WriteLine();
            Console.WriteLine(errors);
        }
        static bool IsPasswordValid(string password, out string errorMessage)
        {
            var isLengthValid = password.Length >= PasswordMinLength;
            var errors = new StringBuilder();
            if (!isLengthValid)
            {
                errors.Append(PasswordLengthErrorMessage);
            }
            var passwordChars = password.ToCharArray();
            bool isFormatValid = true;
            bool containsTwoDigits;
            int digitCount = 0;
            foreach (var character in passwordChars)
            {
                bool isCharOrDigit = Char.IsDigit(character) || Char.IsLetter(character);
                digitCount = Char.IsDigit(character) ? ++digitCount : digitCount;


                if (!isCharOrDigit && isFormatValid)
                {
                    errors.Append(PasswordFormatErrorMessage);
                    isFormatValid = false;
                }
            }
            containsTwoDigits = digitCount >= PasswordDigitsAmount;
            if (!containsTwoDigits)
            {
                errors.Append(PasswordDigitsErrorMessage);
            }
            errorMessage = errors.ToString();
            return isLengthValid && isFormatValid && containsTwoDigits;
        }
    }
}