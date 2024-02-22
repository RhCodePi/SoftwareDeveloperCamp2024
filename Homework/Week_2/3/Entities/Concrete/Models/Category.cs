using Entities.Abstract;
using System;
using System.Collections.Generic;

namespace Entities.Concrete.Models;

public partial class Category : ICategory
{
    public int IdCategory { get; set; }

    public string Categories { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
