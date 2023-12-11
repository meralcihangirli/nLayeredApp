using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateCourseRequest
    {
        public int CategoryId { get; set; }
        public string? Description { get; set; }
        public string? CourseName { get; set; }
    }
}
