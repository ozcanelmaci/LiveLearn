using OnlineCourseManagement.Models.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Entities.Concrete
{
    public class Lesson : IEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
