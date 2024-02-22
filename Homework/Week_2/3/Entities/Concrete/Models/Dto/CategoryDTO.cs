﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Models.Dto
{
    public class CategoryDTO : ICategory
    {
        public string Categories { get; set; } = null!;
    }
}