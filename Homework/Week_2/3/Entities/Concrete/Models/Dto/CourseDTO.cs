using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Models.Dto
{
    public class CourseDTO : ICourse
    {
        public string Name { get; set; } = null!;

        public int CategoryId { get; set; }

        public int InstructorId { get; set; }
    }
}
