using AppServices.Enums;
using AppServices.Owner._shared;

namespace AppServices.Owner.Create.ViewModels
{
    public class CreateOwnerViewModel
    {
        public string Name { get; set; }
        public OwnerStatusEnum Status { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public CreateAddressViewModel Address { get; set; }

        public static implicit operator Domain.Entities.Owner(CreateOwnerViewModel viewModel)
        {
            if (viewModel == null)
            {
                throw new ArgumentNullException("Not Found", nameof(viewModel));
            }

            CreateAddressViewModel address = viewModel.Address;

            var Owner = new Domain.Entities.Owner(viewModel.Name, (Domain.Enums.OwnerStatusEnum)viewModel.Status, address);

            if (!Owner.DocumentValid(viewModel.Document))
                throw new ArgumentNullException("Document Invalid", nameof(viewModel));

            Owner.SetDocument(viewModel.Document);

            if (!Owner.EmailValid(viewModel.Email))
                throw new ArgumentNullException("Email Invalid", nameof(viewModel));

            Owner.SetEmail(viewModel.Email);

            return Owner;
        }
    }
}
