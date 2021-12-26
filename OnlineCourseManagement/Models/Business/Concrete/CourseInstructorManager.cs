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
    public class CourseInstructorManager : ICourseInstructorService
    {
        ICourseInstructorDal _courseInstructorDal;

        public CourseInstructorManager(ICourseInstructorDal courseInstructorDal)
        {
            _courseInstructorDal = courseInstructorDal;
        }

        public IResult Add(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Add(courseInstructor);
            return new SuccessResult();
        }

        public IResult Delete(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Delete(courseInstructor);
            return new SuccessResult();
        }

        public IDataResult<List<CourseInstructor>> GetAll()
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll());
        }

        public IDataResult<CourseInstructor> GetById(int id)
        {
            return new SuccessDataResult<CourseInstructor>(_courseInstructorDal.Get(p=>p.Id == id));
        }

        public IDataResult<List<CourseInstructor>> GetCourseInstructorByCourseId(int id)
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll(p=>p.CourseId == id));
        }

        public IDataResult<List<CourseInstructor>> GetCourseInstructorByUserId(int id)
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll(p => p.UserId == id));
        }

        public IDataResult<List<CourseInstructorDetailDto>> GetCourseInstructorDetails()
        {
            return new SuccessDataResult<List<CourseInstructorDetailDto>>(_courseInstructorDal.GetCourseInstructorDetails());
        }

        public IDataResult<List<CourseInstructorDetailDto>> GetCourseInstructorDetailsByCourseId(int id)
        {
            return new SuccessDataResult<List<CourseInstructorDetailDto>>(_courseInstructorDal.GetCourseInstructorDetails(p=>p.CourseId == id));
        }

        public IDataResult<List<CourseInstructorDetailDto>> GetCourseInstructorDetailsByCourseInstructorId(int id)
        {
            return new SuccessDataResult<List<CourseInstructorDetailDto>>(_courseInstructorDal.GetCourseInstructorDetails(p => p.Id == id));
        }

        public IDataResult<List<CourseInstructorDetailDto>> GetCourseInstructorDetailsByUserId(int id)
        {
            return new SuccessDataResult<List<CourseInstructorDetailDto>>(_courseInstructorDal.GetCourseInstructorDetails(p => p.UserId == id));
        }

        public IResult Update(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Update(courseInstructor);
            return new SuccessResult();
        }
    }
}
