namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new UserDAL());


            foreach (var item in userManager.GetUsers())
            {
                Console.WriteLine($"the user information that {item.Name} and {item.Id}");
            }

        }
    }
}
