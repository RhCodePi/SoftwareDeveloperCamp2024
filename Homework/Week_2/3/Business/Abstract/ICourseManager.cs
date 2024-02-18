using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseManager
    {
        void Add(Course course);
        void Remove(string name);
        void Update(string name, Course course);
        List<Course> GetCourseByInstructor(int instructorId);
        List<Course> GetCourseByCategoryId(int categoryId);
        List<Course> GetAll();
    }
}
