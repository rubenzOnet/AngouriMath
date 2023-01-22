using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngouriMath_App
{
    public class FormatMath2
    {
        public string FormatMathEquation(string equation)
        {

            equation = equation.Replace("(", "").Replace(")", "");
            string[] valores = equation.Split(new char[] { '+', '-' });

            
            for (int i = 0; i < valores.Length; i++)
            {
                if ( (valores[i].Contains("*")) || (valores[i].Contains("/")) )
                {
                    string t = valores[i];

                    // valida si un numero es negativo
                    string[] valoresn = t.Split(new char[] { '*', '/' });
                    for (int y = 0; y < valoresn.Length; y++)
                    {
                        if (valoresn[y].Contains("-"))
                        {
                            int drg = 0;    
                        }
                    }
                    string m = $"({valores[i]})";
                    equation = equation.Replace(t, m);
                }
            }





            return "";
        }
    }
}
