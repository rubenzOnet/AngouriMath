using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AngouriMath_App
{
    public class FormatMathExpression
    {
        public string FormatExpression(string expression)
        {
            // Remove any whitespace from the expression
            expression = expression.Replace(" ", "");


            



            // Add spaces between operators and operands
            // expression = expression.Replace("+", " + ").Replace("-", " - ").Replace("*", " * ").Replace("/", " / ");

            // Add parentheses around negative numbers
            expression = Regex.Replace(expression, @"(?<=\W|^)-(?=\d)", "(-");
            expression = Regex.Replace(expression, @"(?<=\d)\-(?=\W|$)", ")");

   
            // Add parentheses around function calls
            expression = Regex.Replace(expression, @"(?<=\w)\((?=\d)", " ( ");
            expression = Regex.Replace(expression, @"(?<=\d)\)(?=\W|$)", " ) ");

            // Add line breaks after each operator
            // expression = expression.Replace("+", "+\n").Replace("-", "-\n").Replace("*", "*\n").Replace("/", "/\n");
            //expression = expression.Replace("+", "+").Replace("-", "-").Replace("*", "*").Replace("/", "/");

            return expression;
        }
    }
}
