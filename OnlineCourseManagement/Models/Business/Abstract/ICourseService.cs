using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.Entities.Concrete;
using OnlineCourseManagement.Models.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Business.Abstract
{
    public interface ICourseService
    {
        IResult Add(Course course);
        IResult Delete(Course course);
        IResult Update(Course course);
        IDataResult<Course> GetById(int id);
        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetCoursesByCategoryId(int id);

        IDataResult<List<CourseDetailDto>> GetCourseDetails();
        IDataResult<List<CourseDetailDto>> GetCourseDetailsByCourseId(int id);
        IDataResult<List<CourseDetailDto>> GetCourseDetailsByCategoryId(int id);
    }
}
