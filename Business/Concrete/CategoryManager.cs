using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
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
        CategoryBusinessRules _categoryBusinessRules;
        public CategoryManager(ICategoryDal categoryDal, IMapper mapper,CategoryBusinessRules categoryBusinessRules)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
            _categoryBusinessRules = categoryBusinessRules;
        }


        public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
        {
            //Category category=new Category();
            //  category.Id = Guid.NewGuid();
            //  category.CategoryName=createCategory.CategoryName;

            //  Category createdCategory=await _categoryDal.AddAsync(category);
            //  CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse();
            //  createdCategoryResponse.Id = createdCategory.Id;
            //  createdCategoryResponse.CategoryName = createCategory.CategoryName;
            //await _categoryBusinessRules.MaximumCategoryCountIsTen();
            var category = _mapper.Map<Category>(createCategoryRequest);
            var createdCategory = await _categoryDal.AddAsync(category);
            var createdCategoryResponse = _mapper.Map<CreatedCategoryResponse>(createdCategory);
            return createdCategoryResponse;
        }

        public async Task<DeletedCategoryResponse> Delete(DeleteCategoryRequest deleteCategoryRequest)
        {
            var category = _mapper.Map<Category>(deleteCategoryRequest);
            var deletedCategory = await _categoryDal.DeleteAsync(category,true);
            var deletedCategoryResponse = _mapper.Map<DeletedCategoryResponse>(deletedCategory);
            return deletedCategoryResponse;

        }

        public async Task<IPaginate<GetListCategoryResponse>> GetCategoryListAsync()
        {
            var categories = await _categoryDal.GetListAsync();
            var mapped = _mapper.Map<Paginate<GetListCategoryResponse>>(categories);
            return mapped;
        }


        public async Task<UpdatedCategoryResponse> Update(UpdateCategoryRequest updateCategoyRequest)
        {
            var category = _mapper.Map<Category>(updateCategoyRequest);
            var updatedcCategory = await _categoryDal.UpdateAsync(category);
            var updatedCategoryResponse = _mapper.Map<UpdatedCategoryResponse>(updatedcCategory);
            return updatedCategoryResponse;
        }



    }
}
