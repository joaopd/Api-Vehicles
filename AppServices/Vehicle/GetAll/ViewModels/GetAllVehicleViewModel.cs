using AppServices.Brand.GetAll.ViewModels;
using AppServices.Enums;
using AppServices.Owner.GetAll.ViewModels;

namespace AppServices.Vehicle.GetAll.ViewModels
{
    public class GetAllVehicleViewModel
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
        public GetAllOwnerViewModel Owner { get; set; }
        public GetAllBrandViewModel Brand { get; set; }

        public static implicit operator GetAllVehicleViewModel(Domain.Entities.Vehicle entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Not Found", nameof(entity));
            }
            GetAllOwnerViewModel owner = entity.Owner;
            GetAllBrandViewModel brand = entity.Brand;

            GetAllVehicleViewModel VehicleViewModel = new GetAllVehicleViewModel
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
