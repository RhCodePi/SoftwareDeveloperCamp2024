using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace DataAccess.Concrete.InMemory
{
    public class CourseDAL : ICourseDAL
    {
        List<Course> _courses = new List<Course>();

        public CourseDAL() 
        {
            Course course1 = new Course()
            {
                Idcourse = 1,
                Name = "Senior Develoeper Trainnig Camp (.NET)",
                InstructorId = 1,
                CategoryId = 2
            };

            Course course2 = new Course()
            {
                Idcourse = 2,
                Name = "Python",
                InstructorId = 2,
                CategoryId = 2
            };

            Course course3 = new Course()
            {
                Idcourse = 3,
                Name = "Java",
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
            
            _courses.Add((Course)course);

            return course;
        }

        public Course GetCourse(string name)
        {
            return _courses.FirstOrDefault(c => c.Name == name);
        }

        public Course Remove(Course course)
        {
            var result = GetCourse(course.Name);

            if (result == null)
            {
                throw new Exception("Course not found");
            }

            _courses.Remove((Course)result);

            return result;
        }

        public Course Update(Course course)
        {
            var result= GetCourse(course.Name);

            if (result == null)
            {
                return null;
            }
            result.Idcourse = course.Idcourse;
            result.Name = course.Name;
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
