using Entities.Concrete.Models;
using Entities.Concrete.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Mapper
{
    public class CourseMapper
    {
        public static Course GetCourse(CourseDTO courseDto)
        {
            return new Course
            {
                Name = courseDto.Name,
                InstructorId = courseDto.InstructorId,
                CategoryId = courseDto.CategoryId,
            };
        }

        public static CourseDTO MapToDTO(Course course)
        {
            return new CourseDTO
            {
                Name = course.Name,
                InstructorId = course.InstructorId,
                CategoryId = course.CategoryId,
            };
        }

    }
}
