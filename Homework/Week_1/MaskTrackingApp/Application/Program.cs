using Entities.Concrete;
using Business.Concrete;
using Business.Adapters;
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


        // using mernis control system for ptt manager
        PttManager<MernisServiceAdapter> pttManager = new PttManager<MernisServiceAdapter>();

        pttManager.GiveMask(person1);
                
        // pharmacy not using menrnis control system, working with local control
        PharmacyManager<LocalControlManager> pharmacyManager = new PharmacyManager<LocalControlManager>();

        pharmacyManager.GiveMask(person1);

    }
}
