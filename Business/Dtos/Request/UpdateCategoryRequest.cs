using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class UpdateCategoryRequest
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }   
       
    }
}
