using System.Security.Cryptography.X509Certificates;

namespace Consturctors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Steam mySteam = new Steam();

            Steam steam1 = new Steam(1, "Rhcodepi", 98, 3.4m);

            Console.WriteLine(steam1.UserName);
        }
    }


}

public class Steam
{

    // overloading the constructor
    public Steam(int id, string userName, int gameCount, decimal balance)
    {
        Id = id;
        UserName = userName;
        GameCount = gameCount;
        Balance = balance;
    }

    // Default Consturctor like this 
    public Steam()
    {
        Console.WriteLine("Default Consturctor"); 
    }


    public int Id { get; set; }
    public string UserName { get; set; }
    public int GameCount { get; set; }
    public decimal Balance { get; set; }
}
