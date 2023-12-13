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
    public class CustomerMappingProfile :Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<CreateCustomerRequest, Customer>().ReverseMap();
            CreateMap<UpdateCustomerRequest, Customer>().ReverseMap();
            CreateMap<DeleteCustomerRequest, Customer>().ReverseMap();

            CreateMap<Customer, CreatedCustomerResponse>().ReverseMap();
            CreateMap<Paginate<Customer>, Paginate<GetListCustomerResponse>>().ReverseMap();

            CreateMap<Customer, GetListCustomerResponse>().ReverseMap();
            CreateMap<Customer, UpdatedCustomerResponse>().ReverseMap();
            CreateMap<Customer, DeletedCustomerResponse>().ReverseMap();


        }
    }
}
