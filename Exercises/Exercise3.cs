

namespace ProgrammingExercises.Exercises
{
    public static class Exercise3
    {
        public static void PrintEvenNumbers()
        {
            Console.WriteLine("Even number from 1 to 20");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
