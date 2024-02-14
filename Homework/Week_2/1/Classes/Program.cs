namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CityManager cityManager = new CityManager(new CityDAL());

            foreach (var item in cityManager.GetAll())
            {
                Console.WriteLine(item.Name + $" that city on the region : {item.Region}");
            }
        }
    }
}
