using System.Text.RegularExpressions;

namespace AngouriMath_App
{
    public class Mate
    {
        public string FormatMathExpression(string input)
        {
            string temInput = input;

            // set parentheses around multiplication
            temInput = Regex.Replace(temInput, @"(\d+(\.\d+)?\*(\-)?\d+(\.\d+)?)", "($1)");

            // set parentheses around division
            temInput = Regex.Replace(temInput, @"((\-)?\d+(\.\d+)?\/(\-)?\d+(\.\d+)?)", "($1)");

            // set negative number after division 
            temInput = Regex.Replace(temInput, @"(?<=\/)(\-\d+(\.?)(\d+)?)", "($1)");

            // set negative number after multiplication
            temInput = Regex.Replace(temInput, @"(?<=\*)(\-\d+(\.?)(\d+)?)", "($1)");

            temInput = $"({temInput})";

            return temInput;
        }
    }
}
