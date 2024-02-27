using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.CourseRequests
{
    public class CreateCourseRequest
    {
        public string Name { get; set; } = null!;

        public int CategoryId { get; set; }

        public int InstructorId { get; set; }
    }
}
