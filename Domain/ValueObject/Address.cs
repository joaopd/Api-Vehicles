namespace Domain.ValueObject
{
    public class Address
    {

        public string Cep { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }

        public Address(string cep, string state, string city, string neighborhood, string street)
        {
            Cep = cep;
            State = state;
            City = city;
            Neighborhood = neighborhood;
            Street = street;
        }
    }
}
