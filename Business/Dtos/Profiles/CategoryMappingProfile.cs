using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Profiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {//AutoMapper kütüphanesini kullanarak CreateCategoryRequest sınıfından Category sınıfına bir haritalama oluşturur. Bu haritalama, CreateCategoryRequest sınıfının özelliklerini (Category sınıfının alanlarına veya özelliklerine) eşlemek için kullanılabilir.
            CreateMap<CreateCategoryRequest, Category>().ReverseMap();
            CreateMap<UpdateCategoryRequest, Category>().ReverseMap();
            CreateMap<DeleteCategoryRequest, Category>().ReverseMap();

            CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
            CreateMap<Paginate<Category>, Paginate<GetListCategoryResponse>>().ReverseMap();
            CreateMap<Category, GetListCategoryResponse>().ReverseMap();
            CreateMap<Category, UpdatedCategoryResponse>().ReverseMap();
            CreateMap<Category, DeletedCategoryResponse>().ReverseMap();


        }
    }
}
