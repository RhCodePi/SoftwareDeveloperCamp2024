namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();

            list.Add("a");
            list.Add("b");
            list.Add("c");

            Console.WriteLine(list.Count);


            Console.WriteLine(list.SearchItem("d"));

            list.PrintAll();

        }
    }
}
