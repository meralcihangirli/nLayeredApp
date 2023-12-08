using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstract;
using Entitites.Concretes;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        IMapper _mapper;
        public CategoryManager(ICategoryDal categoryDal,IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }


        public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategory)
        {
          //Category category=new Category();
          //  category.Id = Guid.NewGuid();
          //  category.CategoryName=createCategory.CategoryName;

          //  Category createdCategory=await _categoryDal.AddAsync(category);
          //  CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse();
          //  createdCategoryResponse.Id = createdCategory.Id;
          //  createdCategoryResponse.CategoryName = createCategory.CategoryName;
          Category category=_mapper.Map<Category>(createCategory);
            Category createdCategory=await _categoryDal.AddAsync(category);
            CreatedCategoryResponse createdCategoryResponse=_mapper.Map<CreatedCategoryResponse>(createdCategory);


            return createdCategoryResponse;
        }

        public async Task Delete(Category category)
        {
            await _categoryDal.DeleteAsync(category);
        }

        public List<GetListCategoryResponse> GetCategoryListAsync()
        {
            IPaginate<Category> categories = _categoryDal.GetList();
            List<GetListCategoryResponse> response = _mapper.Map<List<GetListCategoryResponse>> (categories.Items);
            return response;
        }

        public async Task<IPaginate<Category>> GetListAsync()
        {
            return await _categoryDal.GetListAsync();
        }

        public async Task Update(Category category)
        {
           await _categoryDal.UpdateAsync(category);
        }
    }
}
