namespace AppServices.Owner._shared
{
    public class CreateAddressViewModel
    {
        public string Cep { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }

        public static implicit operator Domain.ValueObject.Address(CreateAddressViewModel viewModel)
        {
            if (viewModel == null)
            {
                throw new ArgumentNullException("Not Found", nameof(viewModel));
            }

            var address = new Domain.ValueObject.Address(viewModel.Cep, viewModel.State, viewModel.City, viewModel.Neighborhood, viewModel.Street);

            return address;
        }
    }
}
