using Entities.Abstract;
using Entities.Concrete;
using Entities.Concrete.Models;
using Entities.Concrete.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseManager
    {
        Course Add(CourseDTO courseDto);
        Course Remove(string name);
        Course Update(string name, CourseDTO courseDTO, bool[] parameters);
        CourseDTO GetCourse(string name);
        List<CourseDTO> GetCourseByInstructor(int instructorId);
        List<CourseDTO> GetCourseByCategoryId(int categoryId);
        List<CourseDTO> GetAll();
    }
}
