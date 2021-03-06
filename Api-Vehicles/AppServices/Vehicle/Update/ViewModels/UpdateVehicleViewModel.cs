using AppServices.Enums;

namespace AppServices.Vehicle.Updates.ViewModels
{
    public class UpdateVehicleViewModel
    {
        public Guid Id { get; set; }
        public string Renavan { get; set; }
        public string Model { get; set; }
        public string YearOfManufacture { get; set; }
        public string YearModel { get; set; }
        public string Mileage { get; set; }
        public VehicleStatusEnum Status { get; set; }
        public decimal Value { get; set; }
        public Guid OwnerId { get; set; }
        public Guid BrandId { get; set; }

        public static implicit operator Domain.Entities.Vehicle(UpdateVehicleViewModel viewModel)
        {
            if (viewModel == null)
            {
                throw new ArgumentNullException("Not Found", nameof(viewModel));
            }

            var vehicle = new Domain.Entities.Vehicle(viewModel.Renavan, viewModel.Model, viewModel.YearOfManufacture, viewModel.YearModel, viewModel.Mileage, (Domain.Enums.VehicleStatusEnum)viewModel.Status, viewModel.Value);

            vehicle.Id = viewModel.Id;

            return vehicle;
        }
    }
}
