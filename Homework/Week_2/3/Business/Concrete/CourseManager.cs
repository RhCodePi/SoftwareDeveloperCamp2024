using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete.Mapper;
using Entities.Concrete.Models;
using Entities.Concrete.Models.Dto;


namespace Business.Concrete
{
    public class CourseManager : ICourseManager
    {
        private ICourseDAL _courseDAL;

        public CourseManager(ICourseDAL courseDAL)
        {
            _courseDAL = courseDAL;
        }


        public CourseDTO GetCourse(string name)
        {
            var course = _courseDAL.GetCourse(name);
            if (course == null)
                return null;

            var result = CourseMapper.MapToDTO(course);

            return result;
        }


        public Course Add(CourseDTO courseDto)
        {
            if (courseDto == null)
                throw new Exception("Invalid Course Entering");

            var result = CourseMapper.GetCourse(courseDto);

            _courseDAL.Add(result);

            return result;
        }

        public List<CourseDTO> GetAll()
        {
            var courses = _courseDAL.GetALL();

            if(courses.Count <= 0)
                throw new Exception("Courses Not found");

            var result = courses.Select(c => CourseMapper.MapToDTO(c)).ToList();

            return result;
        }

        public List<CourseDTO> GetCourseByCategoryId(int categoryId)
        {
            var courses = _courseDAL.GetCourseByCategoryId(categoryId);

            if (courses == null)
                throw new Exception("Category not found");

            var result = courses.Select(c => CourseMapper.MapToDTO(c)).ToList();

            return result;
        }

        public List<CourseDTO> GetCourseByInstructor(int instructorId)
        {
            var courses = _courseDAL.GetByInstructorId(instructorId);

            if (courses == null)
                throw new Exception("Instructor not found");

            var result = courses.Select(c => CourseMapper.MapToDTO(c)).ToList();

            return result;
        }

        public Course Remove(string name)
        {
            var result = _courseDAL.GetCourse(name);

            if(result == null)
                throw new Exception("Invalid removi");

            _courseDAL.Remove(result);

            //Console.WriteLine($"Deletion =>>> {name} success");
            return result;
        }

        public Course Update(string name, CourseDTO courseDto, bool[] parameters)
        {
            if (courseDto == null)
                throw new Exception("Invalid course entring");

            var course = CourseMapper.GetCourse(courseDto);
            var result = _courseDAL.GetCourse(name);

            if (result == null)
                throw new Exception("Course not found");

            result.Name = (parameters[0]) ? course.Name : result.Name;
            result.CategoryId = (parameters[1]) ? course.CategoryId: result.CategoryId;
            result.InstructorId = (parameters[2]) ? course.InstructorId : result.InstructorId;

            _courseDAL.Update(result);
            //Console.WriteLine($"Updating =>>> {((Course)course).Name} success");
            return result;
        }
    }
}
