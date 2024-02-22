using Entities.Concrete.Models;
using Entities.Concrete.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorManager
    {
        Instructor DeleteInstructor(int id);
        Instructor AddInstructor(InstructorDTO instructorDTO);
        List<Instructor> GetAll();
        Instructor GetInstructorById(int id);
        Instructor GetInstructorByName(string name);
    }
}
