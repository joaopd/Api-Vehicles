using Domain.Enums;

namespace Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; private set; }
        public BrandStatusEnum Status { get; private set; }

        public Brand() { }

        public Brand(string name, BrandStatusEnum status)
        {
            Name = name;
            Status = status;
        }   

        public void SetStatus(BrandStatusEnum status)
        {
            Status = status;
        }
    }
}
