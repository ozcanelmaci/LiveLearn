using OnlineCourseManagement.Models.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Entities.DTOs
{
    public class LessonDetailDto : IDto
    {
        public String Title { get; set; }
        public String CourseName { get; set; }
        public String Description { get; set; }
        public String CategoryName { get; set; }
    }
}
