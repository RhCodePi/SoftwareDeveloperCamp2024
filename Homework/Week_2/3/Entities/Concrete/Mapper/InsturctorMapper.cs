using Entities.Concrete.Models;
using Entities.Concrete.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Mapper
{
    public class InsturctorMapper
    {
        public static Instructor GetInstructor(InstructorDTO instructorDto)
        {
            return new Instructor
            {
                Name = instructorDto.Name,
            };
        }
    }
}
