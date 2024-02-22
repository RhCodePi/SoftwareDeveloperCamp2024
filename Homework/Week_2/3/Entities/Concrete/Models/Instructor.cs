using Entities.Abstract;
using System;
using System.Collections.Generic;

namespace Entities.Concrete.Models;

public partial class Instructor: IInstructor
{
    public int IdInstructor { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
