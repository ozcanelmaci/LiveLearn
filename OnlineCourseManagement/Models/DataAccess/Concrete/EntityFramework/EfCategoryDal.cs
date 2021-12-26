using OnlineCourseManagement.Models.Core.DataAccess.EntityFramework;
using OnlineCourseManagement.Models.DataAccess.Abstract;
using OnlineCourseManagement.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,LiveLearnContext>, ICategoryDal
    {

    }
}
