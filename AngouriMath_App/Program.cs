using AngouriMath;
using AngouriMath_App;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.RegularExpressions;



string input = "The quick brown fox";
string pattern = "\\w+";
MatchCollection matches = Regex.Matches(input, pattern);
foreach (Match match in matches)
    Console.WriteLine(match.Value);

// este es un codigo de ejemplo

// string ecuacion = "40/-5";
// string ecuacion = "6*45/12";
// string ecuacion = "6*45/-12";
// string ecuacion = "40/-5+6*45/12";
// string ecuacion = "40/-5+6*-45/12";
// string ecuacion = "-40/-5+6*-45/-12";
// string ecuacion = "6*-5+10+5";
// string ecuacion = "40/-5+6*45/-5+6";
// string ecuacion = "6*-5+10+5";
// string ecuacion = "40/(-5)";
// string ecuacion = "40/-5+6*45/-5+6";
// string ecuacion = "4.5*2-8+18/3";
// string ecuacion = "50-9*3+13+5-8+4*2";
// string ecuacion = "50-9.5*3+13+5-8+4*2+10/2";
// string ecuacion = "50-9*3+13+5-8+4*2+10/-2";
string ecuacion = "50-9*-3+13+5-8+4*2+10/-2";


Mate mate = new Mate();
string result = mate.FormatMathExpression(ecuacion);



//Entity expr = "6*(-5)+10+5";
//var MathExp = $"({expr.ToString()})".Replace(" ", "") ;  
//Console.WriteLine(MathExp);


//var stingEcuacion = "40/-5+6*-45/12";
//string[] valores = stingEcuacion.Split(new char[] {'/', '*', '^' });


//FormatMathExpression fme = new FormatMathExpression();
//string resultado = fme.FormatExpression(ecuacion);

//Console.WriteLine(resultado);

//FormatMath2 formatMath = new FormatMath2();
//string result = formatMath.FormatMathEquation(ecuacion);

Console.WriteLine(result);

Console.ReadKey();



