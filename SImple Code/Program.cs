using System;
using System.Globalization;


namespace SImple_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 27;
            int y = 5;
            Console.WriteLine(x % y);


            double firstValue, secondValue;
            Console.WriteLine("Please enter first value:");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second value:");

            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;

            Console.WriteLine("Avarage for two numbers = " + result);









        }
    }
}
