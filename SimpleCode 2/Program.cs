using System;

namespace SimpleCode_2
{
    class Program
    {
        static void Main(string[] args)
        {
           

            double firstValue, secondValue, thirdValue;
            Console.WriteLine("Please enter first value:");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second value:");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second value:");

            thirdValue = double.Parse(Console.ReadLine());

            double SumResult = firstValue + secondValue + thirdValue;

            double multResult = firstValue * secondValue * thirdValue;

            Console.WriteLine("Summ of three numbers "+ SumResult );
            Console.WriteLine("Multiplication of three numbers " + multResult);




        }
    }
}
