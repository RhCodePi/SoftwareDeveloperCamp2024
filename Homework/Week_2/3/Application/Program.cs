using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete.Models;

namespace Application
{
    internal class Program
    {
        static void Main()
        {
            // Using inmemory data 
            CategoryManager categoryManager = new CategoryManager(new CategoryDAL());
            CourseManager courseManager = new CourseManager(new CourseDAL());
            InstructorManager instructorManager = new InstructorManager(new InstructorDAL());


            // adding new course
            Course course = new Course()
            {
                Idcourse = courseManager.GetAll().Count + 1,
                Name = "Learn the Linux",
                CategoryId = 1,
                InstructorId = 1,
            };

            courseManager.Add(course);
            
            Console.WriteLine("------------------");

            //Get all course avaible
            foreach (var item in courseManager.GetAll())
            {
                Console.WriteLine(((Course)item).Name);
            }

            Console.WriteLine("------------------");

            // listing for CyberSecurity category
            foreach (var item in courseManager
                .GetCourseByCategoryId(categoryManager
                .GetByCategoryName(Categories.CyberSecurity.ToString()).IdCategory)
                )
            {
                Console.WriteLine($"{((Course)item).Name} -----------------" +
                    $" {instructorManager.GetInstructorById(((Course)item).InstructorId).Name}");
            }



            Course updateCourse = new Course()
            {
                Idcourse = course.Idcourse,
                Name = "Linux",
                CategoryId= 1,
                InstructorId = 2,
            };

            // Update data
            courseManager.Update(course.Name, updateCourse);
            



            // Remove the updated data 
            //courseManager.Remove(course.Name);

            Console.WriteLine("------------------");

            foreach (var item in courseManager.GetAll())
            {
                Console.WriteLine(((Course)item).Name);
            }

            
        }
    }
}
