using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CategoryResponses
{
    public class CreatedCategoryResponse
    {
        public int IdCategory { get; set; }

        public string Categories { get; set; } = null!;
    }
}
