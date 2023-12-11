using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
       // Task<IPaginate<Course>> GetListAsync();
        Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest);
        Task<IPaginate<GetListCourseResponse>> GetCourseListAsync();

        Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest);
        Task<DeletedCourseResponse> Delete(DeleteCourseRequest deleteCourseRequest);
    }

}
