using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourseManagement.Models.Business.Abstract
{
    public interface ICourseImageService
    {
        IResult Add(CourseImage courseImage);
        IResult Delete(CourseImage courseImage);
        IResult Update(CourseImage courseImage);
        IDataResult<CourseImage> GetById(int id);
        IDataResult<CourseImage> GetByCourseId(int courseId);
        IDataResult<List<CourseImage>> GetAll();
    }
}
