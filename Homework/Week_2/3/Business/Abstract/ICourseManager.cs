using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Responses.CourseResponses;

namespace Business.Abstract
{
    public interface ICourseManager
    {
        CreatedCourseResponse Add(CreateCourseRequest courseRequest);
        CreatedCourseResponse Remove(string name);
        CreatedCourseResponse Update(string name, CreateCourseRequest courseRequest, bool[] parameters);
        CreatedCourseResponse GetCourse(string name);
        List<GetAllCourseResponse> GetCourseByInstructor(int instructorId);
        List<GetAllCourseResponse> GetCourseByCategoryId(int categoryId);
        List<GetAllCourseResponse> GetAll();
    }
}
