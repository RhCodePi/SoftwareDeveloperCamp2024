using System.Dynamic;
using System.Numerics;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter 1-100 one number");

            var random = new Random().Next(0, 100);

            var input = Console.ReadLine();
            int guess;

            while (true)
            {
                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine($"your guess is {result}");
                    guess = result;
                    break;
                }
                else
                {
                    input = Console.ReadLine();
                    Console.WriteLine("Invalid input. Please enter a valid integer value");
                }
            }

            if (guess == random)
                Console.WriteLine("You win");
            else
                Console.WriteLine($"You loose number is {random}");

        }
    }
}
