using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Owner._shared
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
                throw new ArgumentNullException("Objeto Vazio", nameof(viewModel));
            }

            var address = new Domain.ValueObject.Address(viewModel.Cep, viewModel.State, viewModel.City, viewModel.Neighborhood, viewModel.Street);

            return address;
        }
    }
}
