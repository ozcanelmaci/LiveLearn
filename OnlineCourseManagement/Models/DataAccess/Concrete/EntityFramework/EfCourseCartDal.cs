using OnlineCourseManagement.Models.Core.DataAccess.EntityFramework;
using OnlineCourseManagement.Models.DataAccess.Abstract;
using OnlineCourseManagement.Models.Entities.Concrete;
using OnlineCourseManagement.Models.Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace OnlineCourseManagement.Models.DataAccess.Concrete.EntityFramework
{
    public class EfCourseCartDal : EfEntityRepositoryBase<CourseCart, LiveLearnContext>, ICourseCartDal
    {
    }
}
