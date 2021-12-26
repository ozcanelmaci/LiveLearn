using OnlineCourseManagement.Models.Core.DataAccess;
using OnlineCourseManagement.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {

    }
}
