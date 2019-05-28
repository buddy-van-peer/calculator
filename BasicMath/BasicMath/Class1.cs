using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    public class Arithmetic
    {
        public static double Add(double num1, double num2)
        {
            return (num1 + num2);
        }
        public static double Sub(double num1, double num2)
        {
            return (num1 - num2);
        }
        public static double Div(double num1, double num2)
        {
            return (num1 / num2);
        }
        public static double Mult(double num1, double num2)
        {
            return (num1 * num2);
        }
    }

    public class Trigonometric
    {
        public static double Sin(double num)
        {
            return Math.Sin(num);
        }
        public static double Cos(double num)
        {        
            return Math.Cos(num);
        }
        public static double Tan(double num)
        {
            return Math.Tan(num);
        }
    }

    public class Algebraic
    {
        public static double Sqrt(double num)
        {
            return Math.Sqrt(num);           
        }
        public static double Cbrt(double num)
        {
            return Math.Ceiling(Math.Pow(num, 1.0 / 3.0));
        }
        public static double inverse(double num)
        {
            return 1 / num;
        }
    }
}
