using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
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
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
            Course course =new Course();
            course.Id = Guid.NewGuid();
            course.CourseName = createCourseRequest.CourseName;
            course.Description = createCourseRequest.Description;

           
            Course createdCourse = await _courseDal.AddAsync(course);

            CreatedCourseResponse createdCourseResponse = new CreatedCourseResponse();

            createdCourseResponse.Id=createdCourse.Id;
            createdCourseResponse.CourseName=createdCourse.CourseName;
            createdCourseResponse.Description=createdCourse.Description;

           return createdCourseResponse;
        }

        public async Task<IPaginate<Course>> GetListAsync()
        {
            return await _courseDal.GetListAsync();
        }
    }
}
