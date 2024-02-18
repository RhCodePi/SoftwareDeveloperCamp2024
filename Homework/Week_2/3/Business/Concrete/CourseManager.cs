using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseManager
    {
        private ICourseDAL _courseDAL;

        public CourseManager(ICourseDAL courseDAL)
        {
            _courseDAL = courseDAL;
        }


        public void Add(Course course)
        {
            _courseDAL.Add(course);
        }

        public List<Course> GetAll()
        {
            return _courseDAL.GetALL();
        }

        public List<Course> GetCourseByCategoryId(int categoryId)
        {
            return _courseDAL.GetCourseByCategoryId(categoryId);
        }

        public List<Course> GetCourseByInstructor(int instructorId)
        {
            return _courseDAL.GetByInstructorId(instructorId);
        }

        public void Remove(string name)
        {
            _courseDAL.Remove(name);
            Console.WriteLine($"Deletion =>>> {name} success");
        }

        public void Update(string name, Course course)
        {
            _courseDAL.Update(name, course);
            Console.WriteLine($"Updating =>>> {course.Name} success");

        }
    }
}
