using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<User> GetById(int id);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByMail(string email);
    }
}
