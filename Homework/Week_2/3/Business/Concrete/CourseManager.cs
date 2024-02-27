using Business.Abstract;
using Business.Dtos.Mapper;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Responses.CourseResponses;
using DataAccess.Abstract;


namespace Business.Concrete
{
    public class CourseManager : ICourseManager
    {
        private ICourseDAL _courseDAL;

        public CourseManager(ICourseDAL courseDAL)
        {
            _courseDAL = courseDAL;
        }


        public CreatedCourseResponse GetCourse(string name)
        {
            var course = _courseDAL.GetCourse(name);
            if (course == null)
            {
                throw new Exception("Invalid Course");
            }

            var response = CourseMapper.GetResponseFromCourse(course);

            return response;
        }


        public CreatedCourseResponse Add(CreateCourseRequest createCourseRequest)
        {
            if (createCourseRequest == null)
                throw new Exception("Invalid Course Entering");

            var course = CourseMapper.GetCourseFromRequest(createCourseRequest);

            _courseDAL.Add(course);

            var response = CourseMapper.GetResponseFromCourse(course);

            return response;
        }

        public List<GetAllCourseResponse> GetAll()
        {
            var courses = _courseDAL.GetALL();

            if(courses.Count <= 0)
                throw new Exception("Courses Not found");

            var response = courses.Select(c => CourseMapper.GetAllResponseFromCourse(c)).ToList();

            return response;
        }

        public List<GetAllCourseResponse> GetCourseByCategoryId(int categoryId)
        {
            var courses = _courseDAL.GetCourseByCategoryId(categoryId);

            if (courses == null)
                throw new Exception("Category not found");

            var response = courses.Select(c => CourseMapper.GetAllResponseFromCourse(c)).ToList();

            return response;
        }

        public List<GetAllCourseResponse> GetCourseByInstructor(int instructorId)
        {
            var courses = _courseDAL.GetByInstructorId(instructorId);

            if (courses == null)
                throw new Exception("Instructor not found");

            var response = courses.Select(c => CourseMapper.GetAllResponseFromCourse(c)).ToList();

            return response;
        }

        public CreatedCourseResponse Remove(string name)
        {
            var course = _courseDAL.GetCourse(name);

            if(course == null)
                throw new Exception("Invalid removi");

            _courseDAL.Remove(course);

            var response = CourseMapper.GetResponseFromCourse(course);

            //Console.WriteLine($"Deletion =>>> {name} success");
            return response;
        }

        public CreatedCourseResponse Update(string name, CreateCourseRequest createCourseRequest, bool[] parameters)
        {
            if (createCourseRequest == null)
                throw new Exception("Invalid course entring");

            var course = CourseMapper.GetCourseFromRequest(createCourseRequest);
            var result = _courseDAL.GetCourse(name);

            if (result == null)
                throw new Exception("Course not found");

            result.Name = (parameters[0]) ? course.Name : result.Name;
            result.CategoryId = (parameters[1]) ? course.CategoryId: result.CategoryId;
            result.InstructorId = (parameters[2]) ? course.InstructorId : result.InstructorId;

            _courseDAL.Update(result);

            var response = CourseMapper.GetResponseFromCourse(result);

            //Console.WriteLine($"Updating =>>> {((Course)course).Name} success");
            return response;
        }
    }
}
