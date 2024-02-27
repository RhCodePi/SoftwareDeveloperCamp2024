using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Responses.InstructorResponses;
using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Mapper
{
    public class InstructorMapper
    {
        public static Instructor GetInstructorFromRequest(CreateInstructorRequest createInstructorRequest)
        {
            return new Instructor
            {
                Name = createInstructorRequest.Name,
            };
        }

        public static CreatedInstructorResponse GetResponseFromInstructor(Instructor instructor)
        {
            return new CreatedInstructorResponse
            {
                IdInstructor = instructor.IdInstructor,
                Name = instructor.Name,
            };
        }

        public static GetAllInstructorResponse GetAllResponseFromInstructor(Instructor instructor)
        {
            throw new NotImplementedException();
        }
    }
}
