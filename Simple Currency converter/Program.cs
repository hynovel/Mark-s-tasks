using System;

namespace Simple_Currency_converter
{
    class Program
    {
        static void Main(string[] args)
        {

           


            double UsdToNzd = 1.75;
            double UsdToKzt = 444.85;

            double UsdToRub = 79.48;
            

            double USD;
            Console.WriteLine("Enter amount in USD ");

            USD = double.Parse(Console.ReadLine());

         
            Console.WriteLine(USD + " in NZD " + USD * UsdToNzd);
            Console.WriteLine(USD + " in KZT " + USD * UsdToKzt);
            Console.WriteLine(USD + " in RUB " + USD * UsdToRub);
            
            if(UsdToRub< 85)
            {
                Console.WriteLine("Too low");
            }
            else
            {

                Console.WriteLine("Too high");
            }

        }
    }
}
