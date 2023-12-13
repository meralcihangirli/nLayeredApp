using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entitites.Concretes;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Profiles
{
    public class ProductMappingProfiles :Profile
    {
        public ProductMappingProfiles()
        {
            CreateMap<Paginate<Product>,Paginate<GetListProductResponse>>().ReverseMap();
            CreateMap<Product, GetListProductResponse>().ForMember(destinationMember: p => p.CategoryName, memberOptions: opt => opt.MapFrom(p => p.Category.CategoryName)).ReverseMap();

          
            //CreateMap<Product, CreatedProductResponse>().ForMember(destinationMember: p => p.Id, memberOptions: opt => opt.MapFrom(p => p.Category.Id)).ReverseMap();


            CreateMap<Product,UpdatedProductResponse>().ReverseMap();
            CreateMap<Product,DeletedProductResponse>().ReverseMap();
            CreateMap<Product, CreatedProductResponse>().ReverseMap();

            CreateMap<CreateProductRequest,Product>().ReverseMap();
            CreateMap<UpdateProductRequest,Product>().ReverseMap();
            CreateMap<DeleteProductRequest,Product>().ReverseMap();
        }
    }
}
