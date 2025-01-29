using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercises.Exercises
{
    public static class Exercise4
    {
        public static void MaximumOfThreeNumbers()
        {
            Console.WriteLine("Enter three Numbers");

            int num1, num2, num3;

            while (true)
            {
                Console.Write("Enter first number: ");
                if (int.TryParse(Console.ReadLine(), out num1)) break;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            while (true)
            {
                Console.Write("Enter second number: ");
                if (int.TryParse(Console.ReadLine(), out num2)) break;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            while (true)
            {
                Console.Write("Enter third number: ");
                if (int.TryParse(Console.ReadLine(), out num3)) break;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            int max = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine($"The maximum numbers is: {max}");

        }
    }
}
