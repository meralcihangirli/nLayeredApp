using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CategoryMappingProfile :Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, GetListCategoryResponse>();
            CreateMap<Category, CreatedCategoryResponse>();
            CreateMap<CreateCategoryRequest, Category>();
        }
    }
}
