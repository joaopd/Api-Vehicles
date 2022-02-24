using AppServices.Enums;
using AppServices.Owner._shared;

namespace AppServices.Owner.GetActived.ViewModels
{
    public class GetActivedOwnerViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public GetAddressViewModel Address { get; set; }
        public OwnerStatusEnum Status { get; set; }

        public static implicit operator GetActivedOwnerViewModel(Domain.Entities.Owner entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Not Found", nameof(entity));
            }
            GetAddressViewModel address = entity.Address;

            GetActivedOwnerViewModel OwnerViewModel = new GetActivedOwnerViewModel
            {
                Id = entity.Id,
                Address = address,
                Email = entity.Email,
                Document = entity.Document,
                Name = entity.Name,
                CreateDate = entity.CreatedDate,
                Status = (OwnerStatusEnum)entity.Status
            };

            return OwnerViewModel;
        }
    }
}
