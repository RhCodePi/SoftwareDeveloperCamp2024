using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.InstructorResponses
{
    public class CreatedInstructorResponse
    {
        public int IdInstructor { get; set; }

        public string Name { get; set; } = null!;
    }
}
