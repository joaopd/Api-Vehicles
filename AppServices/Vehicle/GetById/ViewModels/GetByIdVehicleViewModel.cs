using AppServices.Brand.GetById.ViewModels;
using AppServices.Enums;
using AppServices.Owner.GetById.ViewModels;

namespace AppServices.Vehicle.GetById.ViewModels
{
    public class GetByIdVehicleViewModel
    {
        public Guid Id { get; set; }
        public string Renavan { get; set; }
        public string Model { get; set; }
        public string YearOfManufacture { get; set; }
        public string YearModel { get; set; }
        public string Mileage { get; set; }
        public VehicleStatusEnum Status { get; set; }
        public decimal Value { get; set; }
        public DateTime CreateDate { get; set; }
        public GetByIdOwnerViewModel Owner { get; set; }
        public GetByIdBrandViewModel Brand { get; set; }

        public static implicit operator GetByIdVehicleViewModel(Domain.Entities.Vehicle entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Not Found", nameof(entity));
            }

            GetByIdOwnerViewModel owner = entity.Owner;
            GetByIdBrandViewModel brand = entity.Brand;

            GetByIdVehicleViewModel VehicleViewModel = new GetByIdVehicleViewModel
            {
                Id = entity.Id,
                CreateDate = entity.CreatedDate,
                Status = (VehicleStatusEnum)entity.Status,
                Owner = owner,
                Brand = brand,
                Model = entity.Model,
                YearOfManufacture = entity.YearOfManufacture,
                YearModel = entity.YearModel,
                Mileage = entity.Mileage,
                Renavan = entity.Renavan,
                Value = entity.Value
            };

            return VehicleViewModel;

        }
    }
}
