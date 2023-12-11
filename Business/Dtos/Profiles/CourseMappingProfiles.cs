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
    public class CourseMappingProfiles : Profile
    {
        public CourseMappingProfiles()
        {
            CreateMap<Paginate<Course>, Paginate<GetListCourseResponse>>().ReverseMap();
            CreateMap<Course,GetListCourseResponse>().ReverseMap();
            CreateMap<Course,UpdatedCourseResponse>().ReverseMap();
            CreateMap<Course,DeletedCourseResponse>().ReverseMap();
            CreateMap<Course, CreatedCourseResponse>().ReverseMap();

            CreateMap<CreateCourseRequest,Course>().ReverseMap();
            CreateMap<UpdateCourseRequest,Course>().ReverseMap();   
            CreateMap<DeleteCourseRequest,Course>().ReverseMap();


        }
    }
}
