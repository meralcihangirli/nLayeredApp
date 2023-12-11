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
    public interface ICategoryService
    {
        //  Task<IPaginate<Category>> GetListAsync();
        Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
        Task<IPaginate<GetListCategoryResponse>> GetCategoryListAsync();
        Task<UpdatedCategoryResponse> Update(UpdateCategoryRequest updateCategoryRequest);
        Task<DeletedCategoryResponse> Delete(DeleteCategoryRequest deleteCategoryRequest);

    }
}
