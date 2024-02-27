using Business.Abstract;
using Business.Dtos.Requests.CourseRequests;
using Microsoft.AspNetCore.Mvc;

namespace WebApI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController
    {
        private ICourseManager _courseManager;

        public CourseController(ICourseManager courseManager)
        {
            _courseManager = courseManager;
        }

        [HttpGet("/course/get/instructorid")]
        public IActionResult GetCourseByInstructorId(int instructorId)
        {
            try
            {
                var result = _courseManager.GetCourseByInstructor(instructorId);

                return new OkObjectResult(result);

            }catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpGet("/course/get/name/")]
        public IActionResult GetCourse(string name) 
        {
            try
            {
                var result = _courseManager.GetCourse(name);

                return new OkObjectResult(result);

            }catch (Exception ex) 
            {
                return new BadRequestObjectResult(ex.Message);
            }
        
        }

        [HttpGet("/course/getall")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _courseManager.GetAll();

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
                throw;
            }
        }

        [HttpPost("/course/add/")]
        public IActionResult AddCourse(CreateCourseRequest courseRequest)
        {
            try
            {
                var result = _courseManager.Add(courseRequest);

                return new OkObjectResult(result);

            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
                throw;
            }
        }

        [HttpDelete("/course/delete/")]
        public IActionResult DeleteCourse(string name)
        {
            try
            {
                var result = _courseManager.Remove(name);

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
                throw;
            }
        }

        [HttpPut("/course/update/")]
        public IActionResult UpdateCourse(string name, CreateCourseRequest courseDTO, 
            bool isFirstInputChange, bool isSecondInputChange, bool isThirdInputChange)
        {
            try
            {
                bool[] inputChanges = new bool[3]
                {
                    isFirstInputChange,
                    isSecondInputChange,
                    isThirdInputChange
                };
                var result = _courseManager.Update(name, courseDTO, inputChanges);

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
                throw;
            }
        }
    }
}
