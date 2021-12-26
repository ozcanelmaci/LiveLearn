using OnlineCourseManagement.Models.Core.DataAccess;
using OnlineCourseManagement.Models.Entities.Concrete;
using OnlineCourseManagement.Models.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineCourseManagement.Models.DataAccess.Abstract
{
    public interface ILessonDal : IEntityRepository<Lesson>
    {
        List<LessonDetailDto> GetLessonDetails(Expression<Func<Lesson, bool>> filter = null);
    }
}
