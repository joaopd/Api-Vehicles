using Domain.Interfaces.BaseInterface;

namespace Domain.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; private set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
    }
}
