using Entities.Concrete;
using Business.Concrete;
namespace Application;

public class Program
{
    static void Main(string[] args)
    {
        // instance for Person object
        Person person1 = new Person();
        person1.FirstName = "Abdullah";
        person1.LastName = "Vural";
        person1.DateOfBirthYear = 2001;
        person1.NationalIdentity = 12345678978;

        // instance for PersonManager
        PersonManager personManger = new PersonManager();

        // instance for PttManager
        PttManager pttManager = new PttManager(personManger);

        // ppt giving mask to person if person exist.
        pttManager.GiveMask(person1);
    }
}
