using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.Entities.Concrete;
using OnlineCourseManagement.Models.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Business.Abstract
{
    public interface ILessonService
    {
        IResult Add(Lesson lesson);
        IResult Delete(Lesson lesson);
        IResult Update(Lesson lesson);
        IDataResult<Lesson> GetById(int id);
        IDataResult<List<Lesson>> GetAll();

        IDataResult<List<LessonDetailDto>> GetLessonDetails();
        IDataResult<List<LessonDetailDto>> GetLessonDetailsByCourseId(int id);

    }
}
