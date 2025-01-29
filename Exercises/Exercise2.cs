using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercises.Exercises
{
    public static class Exercise2
    {
        public static void SumNumbers()  
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of numbers from 1 to 10 is: {sum}");
        }
    }
}
