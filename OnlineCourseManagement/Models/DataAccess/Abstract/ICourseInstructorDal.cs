using OnlineCourseManagement.Models.Core.DataAccess;
using OnlineCourseManagement.Models.Entities.Concrete;
using OnlineCourseManagement.Models.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineCourseManagement.Models.DataAccess.Abstract
{
    public interface ICourseInstructorDal : IEntityRepository<CourseInstructor>
    {
        List<CourseInstructorDetailDto> GetCourseInstructorDetails(Expression<Func<CourseInstructor, bool>> filter = null);
    }
}
