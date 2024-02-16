using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ReferenceTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // reference tpyes like class, interface, array....
            int[] numbers = { 1, 2, 3, };
            int[] numbers2 = { 10, 20, 30, };

            numbers = numbers2; // numbers reference equals to numbers2 reference

            numbers2[0] = 5;

            Console.WriteLine(object.ReferenceEquals(numbers, numbers2)); // therefore return true

            // immutable string reference
            string name = "abdullah";
            string name2 = "hasan";

            name = name2; // name reference equals to name2 reference

            name2 = "Emre";//That assignment creates a new string in memory.
                           //Therefore, name and name2 point to different addresses in memory.
            Console.WriteLine(object.ReferenceEquals(name, name2));// therefore return false


            // class reference 
            Person person = new Customer()
            {
                Id = 1,
                Name = "Abdullah",
                LastName = "Vural",
                CreditCardNumber = "121564832"
            };

            Person person2 = new Customer()
            {
                Id = 1,
                Name = "Cengiz",
                LastName = "Tezcan",
                CreditCardNumber = "13254864"
            };

            person = person2;// person reference equals to person2 reference

            person2.Name = "Ayse";

            Console.WriteLine(person.Name);

            Console.WriteLine(object.ReferenceEquals(person, person2));
        }
    }

    public class Person()
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    public class Customer() : Person
    {
        public string CreditCardNumber { get; set; }
    }

    public class Employee() : Person
    {
        public int EmployeeNumber { get; set; }
    }
}
