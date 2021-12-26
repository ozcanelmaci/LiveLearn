using OnlineCourseManagement.Models.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Entities.DTOs
{
    public class CourseInstructorDetailDto : IDto
    {
        public String Name { get; set; }
        public String CourseName { get; set; }
        public String Email { get; set; }
    }
}
