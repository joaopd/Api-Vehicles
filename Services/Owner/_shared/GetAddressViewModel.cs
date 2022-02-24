namespace Services.Owner._shared
{
    public class GetAddressViewModel
    {
        public string Cep { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }

        public static implicit operator GetAddressViewModel(Domain.ValueObject.Address entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Objeto Vazio", nameof(entity));
            }

            GetAddressViewModel address = new GetAddressViewModel
            {
                Cep = entity.Cep,
                State = entity.State,
                City = entity.City,
                Neighborhood = entity.Neighborhood,
                Street = entity.Street
            };

            return address;
        }
    }
}
