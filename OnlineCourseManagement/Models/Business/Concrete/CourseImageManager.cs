using OnlineCourseManagement.Models.Business.Abstract;
using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.DataAccess.Abstract;
using OnlineCourseManagement.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseManagement.Models.Business.Concrete
{
    public class CourseImageManager : ICourseImageService
    {
        ICourseImageDal _courseImageDal;

        public CourseImageManager(ICourseImageDal courseImageDal)
        {
            _courseImageDal = courseImageDal;
        }

        public IResult Add(CourseImage courseImage)
        {
            _courseImageDal.Add(courseImage);
            return new SuccessResult();
        }

        public IResult Delete(CourseImage courseImage)
        {
            _courseImageDal.Delete(courseImage);
            return new SuccessResult();
        }

        public IDataResult<List<CourseImage>> GetAll()
        {
            return new SuccessDataResult<List<CourseImage>>(_courseImageDal.GetAll());
        }

        public IDataResult<CourseImage> GetByCourseId(int courseId)
        {
            return new SuccessDataResult<CourseImage>(_courseImageDal.Get(p=>p.CourseId == courseId));
        }

        public IDataResult<CourseImage> GetById(int id)
        {
            return new SuccessDataResult<CourseImage>(_courseImageDal.Get(p => p.Id == id));
        }

        public IResult Update(CourseImage courseImage)
        {
            _courseImageDal.Update(courseImage);
            return new SuccessResult();
        }
    }
}
