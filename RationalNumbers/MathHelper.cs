using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.RationalNumbers
{
    public static class MathHelper
    {
        /// <summary>
        /// greatest common divisor of int a and int b
        /// </summary>
        public static int GCD(int a, int b)
        {
            while (a != b)
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            return a;
        }
        /// <summary>
        /// least common multiple of int a and int b
        /// </summary>
        public static int LCM(int a, int b)
        {
            return (Math.Abs(a * b) / GCD(a, b));
        }
    }
}
