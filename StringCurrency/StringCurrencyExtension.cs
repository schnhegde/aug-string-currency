using System.Text.RegularExpressions;
namespace StringCurrency
{
    public static class StringCurrencyExtension
    {
        public static string toCurrency(this string value)
        {
            // int.Parse(value); // inital logic doesnt work for everything has to be an int

            if (Regex.IsMatch(value, @"^\d+$")) // better than trying to parse i assume
            {
                return '$' + value;
            } else
            {
                throw new FormatException();
            }
        }
    }
}