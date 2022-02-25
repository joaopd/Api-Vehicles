using Domain.UoW;
using AppServices.Vehicle.Updates.ViewModels;

namespace AppServices.Vehicle
{
    public class UpdateVehicle : IUpdateVehicle
    {
        private readonly IUnitOfWork _uow;
        public UpdateVehicle(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Guid> Execute(UpdateVehicleViewModel update)
        {
            try
            {
                var getVehicle = await _uow.VehicleRepository.GetById(update.Id);

                if (getVehicle == null)
                    throw new ArgumentNullException("Not Found");

                if (getVehicle.Status != Domain.Enums.VehicleStatusEnum.Available && update.Status == Enums.VehicleStatusEnum.Available)
                    throw new ArgumentNullException("Bad Request");

                Domain.Entities.Vehicle Vehicle = update;

                Vehicle.SetOwnerId(update.OwnerId);
                Vehicle.SetBrandId(update.BrandId);

                var response = await _uow.VehicleRepository.Update(Vehicle);

                return response.Id;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Bad Request", nameof(e));
            }
        }
    }
}
