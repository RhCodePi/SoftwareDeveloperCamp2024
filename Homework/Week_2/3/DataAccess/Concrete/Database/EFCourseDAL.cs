using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete.Models;
using Entities.Concrete.Models.Db;

namespace DataAccess.Concrete.Database
{
    public class EFCourseDAL : ICourseDAL
    {
        private CoursedbContext _dbContext;

        public EFCourseDAL(CoursedbContext coursedbContext)
        {
            _dbContext = coursedbContext;
        }

        public Course Add(Course course)
        {
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return course;
        }

        public List<Course> GetALL()
        {
            return _dbContext.Courses.ToList();
        }

        public List<Course> GetByInstructorId(int instructorId)
        {
            return _dbContext.Courses.Where(c => c.InstructorId == instructorId).ToList();
        }

        public Course GetCourse(string name)
        {
            return _dbContext.Courses.FirstOrDefault(c=> c.Name == name);
        }

        public List<Course> GetCourseByCategoryId(int categoryId)
        {
            return _dbContext.Courses.Where(c => c.CategoryId == categoryId).ToList();
        }

        public Course Remove(Course course)
        {
            _dbContext.Courses.Remove((Course)course);
            _dbContext.SaveChanges();
            return course;
        }

        public Course Update(Course course)
        {
            _dbContext.Courses.Update((Course)course);
            _dbContext.SaveChanges();
            return course;
        }
    }
}
