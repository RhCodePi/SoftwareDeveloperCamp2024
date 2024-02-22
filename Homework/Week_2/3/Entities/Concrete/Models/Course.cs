using Entities.Abstract;
using System;
using System.Collections.Generic;

namespace Entities.Concrete.Models;

public partial class Course : ICourse
{
    public int Idcourse { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public int InstructorId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Instructor Instructor { get; set; } = null!;
}
