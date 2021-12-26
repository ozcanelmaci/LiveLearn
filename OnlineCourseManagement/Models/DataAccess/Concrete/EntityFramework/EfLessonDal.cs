using OnlineCourseManagement.Models.Core.DataAccess.EntityFramework;
using OnlineCourseManagement.Models.DataAccess.Abstract;
using OnlineCourseManagement.Models.Entities.Concrete;
using OnlineCourseManagement.Models.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OnlineCourseManagement.Models.DataAccess.Concrete.EntityFramework
{
    public class EfLessonDal : EfEntityRepositoryBase<Lesson, LiveLearnContext>, ILessonDal
    {
        public List<LessonDetailDto> GetLessonDetails(Expression<Func<Lesson, bool>> filter = null)
        {
            using (LiveLearnContext context = new LiveLearnContext())
            {
                var result = from le in filter == null ? context.Lessons : context.Lessons.Where(filter)
                             join co in context.Courses
                             on le.CourseId equals co.Id
                             join ca in context.Categories
                             on co.CategoryId equals ca.Id
                             orderby le.Id
                             select new LessonDetailDto
                             {
                                 Title = le.Title,
                                 CourseName = co.Name,
                                 Description = co.Description,
                                 CategoryName = ca.Name
                             };
                return result.ToList();
            }
        }
    }
}
