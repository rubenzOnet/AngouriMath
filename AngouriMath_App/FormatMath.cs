namespace AngouriMath_App
{
    public class FormatMath : IFormatMath
    {
        public string FormatMathEquation(string equation)
        {

            equation = equation.Replace("(", "").Replace(")", "");

            string[] valores = equation.Split(new char[] { '/', '*', '^' });

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i].Contains("+"))
                {
                    string[] plussSign = valores[i].Split(new char[] { '+' });
                    string minusSign = string.Empty;

                    foreach (var itemPlus in plussSign)
                    {
                        int numberMinus = int.Parse(itemPlus);
                        if (numberMinus <= 0)
                        {
                            minusSign += $"({itemPlus})";
                        }
                        else
                        {
                            minusSign += $"+{itemPlus}";
                        }
                    }

                    equation = equation.Replace(valores[i], $"{minusSign}");
                }
                else if (valores[i].Contains("-"))
                {
                    equation = equation.Replace(valores[i], $"({valores[i]})");
                }
            }

            equation = $"({equation})";

            return equation;
        }
    }
}
