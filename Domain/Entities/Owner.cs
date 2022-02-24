using Domain.Enums;
using Domain.ValueObject;

namespace Domain.Entities
{
    public class Owner : BaseEntity
    {
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public OwnerStatusEnum Status { get; private set; }
        public Address Address { get; private set; }

        private Owner() { }

        public Owner(string name, string document, string email, OwnerStatusEnum status, Address address)
        {
            Name = name;
            Document = document;
            Email = email;
            Status = status;
            Address = address;
        }

        public void SetAddress(Address address)
        {
            Address = address;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }

        public void SetStatus(OwnerStatusEnum status)
        {
            Status = status;
        }
    }
}
