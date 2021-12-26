using OnlineCourseManagement.Models.Core.Entities.Abstract;

namespace OnlineCourseManagement.Models.Entities.DTOs
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
