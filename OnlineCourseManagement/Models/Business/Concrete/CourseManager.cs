using OnlineCourseManagement.Models.Business.Abstract;
using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.DataAccess.Abstract;
using OnlineCourseManagement.Models.Entities.Concrete;
using OnlineCourseManagement.Models.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            _courseDal.Add(course);
            return new SuccessResult();
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult();
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll());
        }

        public IDataResult<Course> GetById(int id)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Course>> GetCoursesByCategoryId(int id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p=>p.CategoryId == id));
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetails()
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails());
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetailsByCategoryId(int id)
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails(p=>p.CategoryId == id));
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetailsByCourseId(int id)
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails(p => p.Id == id));
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult();
        }
    }
}
