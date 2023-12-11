using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        IMapper _mapper;
        
        public CourseManager(ICourseDal courseDal,IMapper mapper)
        {
            _courseDal = courseDal;
            _mapper = mapper;
         
        }

        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
            // Course course =new Course();
            // course.Id = Guid.NewGuid();
            // course.CourseName = createCourseRequest.CourseName;
            // course.Description = createCourseRequest.Description;                   
            // Course createdCourse = await _courseDal.AddAsync(course);
            // CreatedCourseResponse createdCourseResponse = new CreatedCourseResponse();
            // createdCourseResponse.Id=createdCourse.Id;
            // createdCourseResponse.CourseName=createdCourse.CourseName;
            // createdCourseResponse.Description=createdCourse.Description;
            //return createdCourseResponse;
            
           var course=_mapper.Map<Course>(createCourseRequest);
            var createdCourse=await _courseDal.AddAsync(course);//bana kategori veriyor
            var createdCourseResponse=_mapper.Map<CreatedCourseResponse>(createdCourse);//verilen kategorinin yannıtı dönüyor
           // CreatedCategoryResponse createdCourseResponse=_mapper.Map<CreatedCategoryResponse>(createdCourse);

            return createdCourseResponse;
        }

        public async Task<DeletedCourseResponse> Delete(DeleteCourseRequest deleteCourseRequest)
        {
           var course=_mapper.Map<Course>(deleteCourseRequest);
            var deletedCourse=await _courseDal.DeleteAsync(course,true);
            var deletedCourseResponse=_mapper.Map<DeletedCourseResponse>(deletedCourse);
            return deletedCourseResponse;
        }

        public async Task<IPaginate<GetListCourseResponse>> GetCourseListAsync()
        {
            var courseList = await _courseDal.GetListAsync();
            var mappedList=_mapper.Map<Paginate<GetListCourseResponse>>(courseList);
            return mappedList;
        }

        public async Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest)
        {
            var course = _mapper.Map<Course>(updateCourseRequest);
            var updatedCourse= await _courseDal.UpdateAsync(course);
            var updatedCourseResponse=_mapper.Map<UpdatedCourseResponse>(updatedCourse);
            return updatedCourseResponse;
        }





        //public async Task<IPaginate<Course>> GetListAsync()
        //{
        //    return await _courseDal.GetListAsync();
        //}
    }
}
