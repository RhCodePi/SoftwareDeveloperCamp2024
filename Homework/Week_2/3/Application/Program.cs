using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using inmemory data 
            CategoryManager categoryManager = new CategoryManager(new CategoryDAL());
            CourseManager courseManager = new CourseManager(new CourseDAL());
            InstructorManager insturctorManager = new InstructorManager(new InsturctorDAL());


            // adding new course
            Course course = new Course()
            {
                Id = courseManager.GetAll().Count + 1,
                Name = "Learn the Linux",
                CategoryId = 1,
                Description = "Learn bacis of the Linux",
                InstructorId = 1,
            };

            courseManager.Add(course);
            
            Console.WriteLine("------------------");

            //Get all course avaible
            foreach (var item in courseManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("------------------");

            // listing for CyberSecurity category
            foreach (var item in courseManager
                .GetCourseByCategoryId(categoryManager
                .GetByCategoryName(Categories.CyberSecurity).Id)
                )
            {
                Console.WriteLine($"{item.Name} -----------------" +
                    $" {insturctorManager.GetInstructorById(item.InstructorId).Name}");
            }



            Course updateCourse = new Course()
            {
                Id = course.Id,
                Name = "Linux",
                CategoryId= 1,
                Description= "Bacis of Linux",
                InstructorId = 2,
            };

            // Update data
            courseManager.Update(course.Name, updateCourse);
            



            // Remove the updated data
            courseManager.Remove(course.Name);

            Console.WriteLine("------------------");

            foreach (var item in courseManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }

            
        }
    }
}
