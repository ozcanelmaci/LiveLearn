using OnlineCourseManagement.Models.Business.Abstract;
using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.DataAccess.Abstract;
using OnlineCourseManagement.Models.Entities.Concrete;
using OnlineCourseManagement.Models.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Business.Concrete
{
    public class LessonManager : ILessonService
    {
        ILessonDal _lessonDal;

        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }

        public IResult Add(Lesson lesson)
        {
            _lessonDal.Add(lesson);
            return new SuccessResult();
        }

        public IResult Delete(Lesson lesson)
        {
            _lessonDal.Delete(lesson);
            return new SuccessResult();
        }

        public IDataResult<List<Lesson>> GetAll()
        {
            return new SuccessDataResult<List<Lesson>>(_lessonDal.GetAll());
        }

        public IDataResult<Lesson> GetById(int id)
        {
            return new SuccessDataResult<Lesson>(_lessonDal.Get(p=>p.Id == id));
        }

        public IDataResult<List<LessonDetailDto>> GetLessonDetails()
        {
            return new SuccessDataResult<List<LessonDetailDto>>(_lessonDal.GetLessonDetails());
        }

        public IDataResult<List<LessonDetailDto>> GetLessonDetailsByCourseId(int id)
        {
            return new SuccessDataResult<List<LessonDetailDto>>(_lessonDal.GetLessonDetails(p=>p.CourseId == id));
        }

        public IResult Update(Lesson lesson)
        {
            _lessonDal.Update(lesson);
            return new SuccessResult();
        }
    }
}
