using Services.Enums;
using Services.Owner._shared;

namespace Services.Owner.GetById.ViewModels
{
    public class GetByIdOwnerViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public DateTime CreateTime { get; set; }
        public GetAddressViewModel Address { get; set; }
        public OwnerStatusEnum Status { get; set; }

        public static implicit operator GetByIdOwnerViewModel(Domain.Entities.Owner entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Objeto Vazio", nameof(entity));
            }
            GetAddressViewModel address = entity.Address;

            GetByIdOwnerViewModel OwnerViewModel = new GetByIdOwnerViewModel
            {
                Id = entity.Id,
                Address = address,
                Email = entity.Email,
                Document = entity.Document,
                Name = entity.Name,
                CreateTime = entity.CreatedDate,
                Status = (OwnerStatusEnum)entity.Status
            };

            return OwnerViewModel;
        }
    }
}
