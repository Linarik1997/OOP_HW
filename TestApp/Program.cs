using System;
using OOP_HW.RationalNumbers;
using OOP_HW.Buildings;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber x = new RationalNumber(1,5);
            RationalNumber y = new RationalNumber(2,5);
            Console.WriteLine((float)y);
            Console.WriteLine(x!=y);
            Console.ReadLine();
        }
    }
}
