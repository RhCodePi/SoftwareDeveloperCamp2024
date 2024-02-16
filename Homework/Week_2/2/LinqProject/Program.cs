namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamaManager gamaManager = new GamaManager();

            var filterList = gamaManager.FilterByCoast(35.4m);

            var developerList = gamaManager.FilterByDeveloper("FromSoftware");


            Console.WriteLine("Filter by Coast {35.4}");
            Console.WriteLine("--------------------------------------");
            foreach (var item in filterList)
            {
                Console.WriteLine(item.Name  +  " Coast : $" + item.Coast);
            }
            
            Console.WriteLine();

            Console.WriteLine("Filter by Developer {FromSoftware} ");
            Console.WriteLine("---------------------------------------");
            foreach (var item in developerList)
            {
                Console.WriteLine(item.Name  +  " Coast : $" + item.Coast);               
            }
        }
    }
}
