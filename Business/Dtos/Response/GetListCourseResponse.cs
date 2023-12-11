
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    //public class GetListCourseResponse : BasePageableModel //sayfalama temel özellikleri barındıran soyut sınıf
    //{
    //    public IList<CourseListDto>? Items { get; set; }
    //DTO'lar, farklı sistemler arasında veri transferi yaparken kullanılan nesnelerdir.
    //}
    public class GetListCourseResponse  
    {
        public Guid Id { get; set; }
        public int CategoryId { get; set; }
        public string? Description { get; set; }
        public string? CourseName { get; set; }
    }
    

}
