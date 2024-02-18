using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class CourseDAL : ICourseDAL
    {
        List<Course> _courses = new List<Course>();

        public CourseDAL() 
        {
            Course course1 = new Course()
            {
                Id = 1,
                Name = "Senior Develoeper Trainnig Camp (.NET)",
                Description = "With a free and professional program, we learn advanced software development.",
                InstructorId = 1,
                CategoryId = 2
            };

            Course course2 = new Course()
            {
                Id = 2,
                Name = "Python",
                Description = "With a free and professional program, we learn advanced software development.",
                InstructorId = 2,
                CategoryId = 2
            };

            Course course3 = new Course()
            {
                Id = 3,
                Name = "Java",
                Description = "With a free and professional program, we learn advanced software development.",
                InstructorId = 1,
                CategoryId = 2
            };

            _courses.AddRange(new List<Course> { course1, course2, course3});
        }


        public Course Add(Course course)
        {
            if (_courses.Contains(course))
            {
                Console.WriteLine("Course already include");
                throw new Exception("Course already include");
            } 
            
            _courses.Add(course);

            return course;
        }

        public Course GetCourse(string name)
        {
            return _courses.FirstOrDefault(c => c.Name == name);
        }

        public Course Remove(string name)
        {
            var result = GetCourse(name);

            if (result == null)
            {
                throw new Exception("Course not found");
            }

            _courses.Remove(result);

            return result;
        }

        public Course Update(string name, Course course)
        {
            var result= GetCourse(name);

            if (result == null)
            {
                throw new Exception("Course not found");
            }

            result.Id = course.Id;
            result.Name = course.Name;
            result.Description = course.Description;
            result.CategoryId = course.CategoryId;
            result.InstructorId = course.InstructorId;

            return result;
        }

        public List<Course> GetByInstructorId(int instructorId)
        {
            return _courses.Where(x => x.InstructorId == instructorId).ToList() ;
        }

        public List<Course> GetCourseByCategoryId(int categoryId)
        {
            return _courses.Where(c => c.CategoryId == categoryId).ToList();
        }

        public List<Course> GetALL()
        {
            return _courses;
        }
    }
}
