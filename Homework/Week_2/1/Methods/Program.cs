namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNo1 = new Random().Next(1, 10);

            int randomNo2 = new Random().Next(1, 10);

            //Print(Add(randomNo2, randomNo1));

            Print("NO_1: " + randomNo1 + " NO_2: " + randomNo2);

            Print(Add(randomNo1, randomNo2), 
                  Sub(randomNo1, randomNo2),
                  Mult(randomNo1, randomNo2),
                  Div(randomNo1, randomNo2)                  
                  );
        }
        // method overload 
        static void Print(string result)
        {
            Console.WriteLine(result);
        }

        static void Print(params int[] results)
        {
            foreach (var result in results)
            {
                Console.WriteLine($"Result is: {result}");
            }
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b) => a - b;

        static int Mult(int a, int b) => a * b;

        static int Div(int a, int b) => a / b;
    }
}
