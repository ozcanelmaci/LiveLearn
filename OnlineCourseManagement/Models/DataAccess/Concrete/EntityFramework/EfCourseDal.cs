using OnlineCourseManagement.Models.Core.DataAccess.EntityFramework;
using OnlineCourseManagement.Models.DataAccess.Abstract;
using OnlineCourseManagement.Models.Entities.Concrete;
using OnlineCourseManagement.Models.Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OnlineCourseManagement.Models.DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfCourseDal : EfEntityRepositoryBase<Course, LiveLearnContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails(Expression<Func<Course, bool>> filter = null)
        {
            using (LiveLearnContext context = new LiveLearnContext())
            {
                var result = from co in filter == null ? context.Courses : context.Courses.Where(filter)
                             join ca in context.Categories
                             on co.CategoryId equals ca.Id
                             orderby co.Id
                             select new CourseDetailDto
                             {
                                 Name = co.Name,
                                 CategoryName = ca.Name,
                                 Description = co.Description,
                             };
                return result.ToList();
            }
        }
    }
}
