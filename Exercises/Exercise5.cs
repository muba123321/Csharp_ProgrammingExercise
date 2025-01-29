using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgrammingExercises.Exercises
{
    public static class Exercise5
    {
        public static void PrimeNumberCheck()
        {
         
            int num;

            while (true)
            {
                Console.WriteLine("Enter a number to check if it is prime:");
                if (int.TryParse(Console.ReadLine(), out num)) break;
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }


            bool isPrime = true;

            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {

                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            Console.WriteLine(isPrime ? $"{num} is a prime number." : $"{num} is not a prime number.");
        }

    }
}
