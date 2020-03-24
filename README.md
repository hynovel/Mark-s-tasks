# Mark-s-tasks
Tasks for practice 

using System;

namespace Mark_s_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 100, number = 0;
            while (value > number)
            {
                number = number + 1;

                if (number % 5 == 0 && number % 3 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (number % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (number % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(number);
            }
        }




















