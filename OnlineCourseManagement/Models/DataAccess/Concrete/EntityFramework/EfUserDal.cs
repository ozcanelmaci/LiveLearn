using OnlineCourseManagement.Models.Core.DataAccess.EntityFramework;
using OnlineCourseManagement.Models.Entities.Concrete;
using OnlineCourseManagement.Models.DataAccess.Abstract;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, LiveLearnContext>, IUserDal
    {

    }
}
