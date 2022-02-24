namespace Core.Entities
{
    public class BaseEntity : IEntidadeBase
    {
        public Guid Id { get; private set; }
        public DateTime CreatedDate { get; private set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
    }
}
