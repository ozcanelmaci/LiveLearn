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
    public class EfCourseInstructorDal : EfEntityRepositoryBase<CourseInstructor, LiveLearnContext>, ICourseInstructorDal
    {
        public List<CourseInstructorDetailDto> GetCourseInstructorDetails(Expression<Func<CourseInstructor, bool>> filter = null)
        {
            using (LiveLearnContext context = new LiveLearnContext())
            {
                var result = from cı in filter == null ? context.CourseInstructors : context.CourseInstructors.Where(filter)
                             join co in context.Courses
                             on cı.CourseId equals co.Id
                             join u in context.Users
                             on cı.UserId equals u.Id
                             orderby cı.Id
                             select new CourseInstructorDetailDto
                             {
                                 Name = u.Name,
                                 CourseName = co.Name,
                                 Email = u.Email
                             };
                return result.ToList();
            }
        }
    }
}

