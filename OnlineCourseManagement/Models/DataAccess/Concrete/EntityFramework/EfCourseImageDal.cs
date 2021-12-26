using OnlineCourseManagement.Models.Core.DataAccess.EntityFramework;
using OnlineCourseManagement.Models.DataAccess.Abstract;
using OnlineCourseManagement.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseManagement.Models.DataAccess.Concrete.EntityFramework
{
    public class EfCourseImageDal : EfEntityRepositoryBase<CourseImage, LiveLearnContext>, ICourseImageDal
    {

    }
}
