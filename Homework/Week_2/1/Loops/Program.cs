namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine()!);
            
            Console.WriteLine(IsPrimeNumber(input));
        }

        static bool IsPrimeNumber(int n)
        {

            var squareRoot = (int)MathF.Sqrt(n);

            for (int i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{n} is not Prime number ");
                    return false;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine($"Prime number is {n}");
            return true;
        }
    }
}
