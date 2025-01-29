
namespace ProgrammingExercises.Exercises
{
    public static class Exercise6
    {
        public static void ReverseString()
        {
            while (true)
            {

                Console.WriteLine("Enter a text to reverse or type exit to quit");

                string? text = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(text))
                {
                    Console.WriteLine("Invalid input! Please enter a valid word or sentence.");
                    continue;
                }

                if (text.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                    break;
                char[] charArray = text.ToCharArray();
                Array.Reverse(charArray);
                string reversed = new(charArray);
                Console.WriteLine($"Reversed string: {reversed}\n");
            }
        }

    }
}
