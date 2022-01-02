using OnlineCourseManagement.Models.Business.Abstract;
using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.DataAccess.Abstract;
using OnlineCourseManagement.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Business.Concrete
{
    public class CourseCartManager : ICourseCartService
    {
        private ICourseCartDal _courseCartDal;
        private ICourseDal _courseDal;

        public CourseCartManager(ICourseCartDal courseCartDal, ICourseDal courseDal)
        {
            _courseCartDal = courseCartDal;
            _courseDal = courseDal;
        }

        public IResult Add(CourseCart courseCart)
        {
            courseCart.ProcessDate = DateTime.Now;
            _courseCartDal.Add(courseCart);
            return new SuccessResult("CourseCart tablosuna eklendi");
        }

        public IResult Delete(CourseCart courseCart)
        {
            _courseCartDal.Delete(courseCart);
            return new SuccessResult();
        }

        public IDataResult<CourseCart> GetById(int id)
        {
            return new SuccessDataResult<CourseCart>(_courseCartDal.Get(p => p.Id == id));
        }

        public IDataResult<List<CourseCart>> GetCourseCartsByUserId(int id)
        {
            return new SuccessDataResult<List<CourseCart>>(_courseCartDal.GetAll(p => p.UserId == id));
        }

        //public IDataResult<List<Course>> GetCoursesByUserIda(int id)
        //{
        //    var result = _courseCartDal.GetAll(p => p.UserId == id);
        //    List<Course> coursesOfUser = new List<Course>();
        //    foreach (var item in result)
        //    {
        //        coursesOfUser.Add(_courseDal.Get(p=>p.Id == item.CourseId));
        //    }
        //    return new SuccessDataResult<List<Course>>(coursesOfUser);
        //}
    }
}
