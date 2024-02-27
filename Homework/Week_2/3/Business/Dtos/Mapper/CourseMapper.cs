using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Responses.CourseResponses;
using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Mapper
{
    public static class CourseMapper
    {
        public static CreatedCourseResponse GetCourseFromResponse(CreateCourseRequest createCourseRequest)
        {
            return new CreatedCourseResponse()
            {
                Name = createCourseRequest.Name,
                CategoryId = createCourseRequest.CategoryId,
                InstructorId = createCourseRequest.InstructorId,
            };
        }

        public static CreateCourseRequest GetCourseFromRequest(CreatedCourseResponse createdCourseResponse)
        {
            return new CreateCourseRequest()
            {
                Name = createdCourseResponse.Name,
                CategoryId = createdCourseResponse.CategoryId,
                InstructorId = createdCourseResponse.InstructorId,
            };
        }

        public static CreatedCourseResponse GetResponseFromCourse(Course course)
        {
            return new CreatedCourseResponse
            {
                Name = course.Name,
                CategoryId = course.CategoryId,
                Id = course.Idcourse,
                InstructorId = course.InstructorId,
            };
        }

        public static Course GetCourseFromRequest(CreateCourseRequest courseRequest)
        {
            return new Course()
            {
                Name = courseRequest.Name,
                CategoryId = courseRequest.CategoryId,
                InstructorId = courseRequest.InstructorId,
            };
        }

        public static GetAllCourseResponse GetAllResponseFromCourse(Course course)
        {
            return new GetAllCourseResponse()
            {
                Id = course.Idcourse,
                Name = course.Name,
                CategoryId = course.CategoryId,
                InstructorId= course.InstructorId,
            };
        }

    }
}
