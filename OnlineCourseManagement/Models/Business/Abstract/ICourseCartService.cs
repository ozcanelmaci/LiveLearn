using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Business.Abstract
{
    public interface ICourseCartService
    {
        IResult Add(CourseCart courseCart);
        IResult Delete(CourseCart courseCart);
        IDataResult<CourseCart> GetById(int id);
        IDataResult<List<CourseCart>> GetCourseCartsByUserId(int id);
    }
}
