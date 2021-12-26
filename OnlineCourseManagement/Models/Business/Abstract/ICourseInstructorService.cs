using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.Entities.Concrete;
using OnlineCourseManagement.Models.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Business.Abstract
{
    public interface ICourseInstructorService
    {
        IResult Add(CourseInstructor courseInstructor);
        IResult Delete(CourseInstructor courseInstructor);
        IResult Update(CourseInstructor courseInstructor);
        IDataResult<CourseInstructor> GetById(int id);
        IDataResult<List<CourseInstructor>> GetAll();

        IDataResult<List<CourseInstructor>> GetCourseInstructorByCourseId(int id);
        IDataResult<List<CourseInstructor>> GetCourseInstructorByUserId(int id);
        IDataResult<List<CourseInstructorDetailDto>> GetCourseInstructorDetails();
        IDataResult<List<CourseInstructorDetailDto>> GetCourseInstructorDetailsByCourseInstructorId(int id);
        IDataResult<List<CourseInstructorDetailDto>> GetCourseInstructorDetailsByCourseId(int id);
        IDataResult<List<CourseInstructorDetailDto>> GetCourseInstructorDetailsByUserId(int id);
    }
}
