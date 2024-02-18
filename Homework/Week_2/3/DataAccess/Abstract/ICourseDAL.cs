using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICourseDAL
    {
        Course Add(Course course);
        Course Remove(string name);
        Course Update(string name, Course course);
        Course GetCourse(string name);
        List<Course> GetCourseByCategoryId(int categoryId);
        List<Course> GetByInstructorId(int instructorId);
        List<Course> GetALL();
    }
}
