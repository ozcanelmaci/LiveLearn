using OnlineCourseManagement.Models.Core.Entities.Abstract;

namespace OnlineCourseManagement.Models.Core.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
