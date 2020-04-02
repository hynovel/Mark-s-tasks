using System;

namespace Mark_s_tasks
{
    public class Program
    {
            public static void Main (string[] args)
            {
               int value = 100, number = 0;
                while (value > number)
                {
                    number = number + 1;

                Console.WriteLine(Calculate(number));
                }
            }

        public static string Calculate(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
                return "FizzBuzz";
            else if (number % 5 == 0)
                return "Buzz";
            else if (number % 3 == 0)
                return "Fizz";
            else
                return number.ToString();
        }


        
        
        
        
            
        
                    
    }
}

            
        
        
        
            
        
 
