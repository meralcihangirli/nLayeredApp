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
        Task<IPaginate<Category>> GetListAsync();
        Task<CreatedCategoryResponse>  Add(CreateCategoryRequest createCategoryRequest);

        List<GetListCategoryResponse> GetCategoryListAsync();
        Task Update(Category category);
        Task Delete(Category category);     
    }
}
