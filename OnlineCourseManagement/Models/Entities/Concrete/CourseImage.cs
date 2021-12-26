using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineCourseManagement.Models.Core.Entities.Abstract;
using System.Text;

namespace OnlineCourseManagement.Models.Entities.Concrete
{
    public class CourseImage : IEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string ImagePath { get; set; }
        public string Link { get; set; }
    }
}

