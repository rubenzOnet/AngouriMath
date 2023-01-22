using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
