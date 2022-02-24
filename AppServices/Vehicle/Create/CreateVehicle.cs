using Domain.UoW;
using AppServices.Vehicle.Create.ViewModels;

namespace AppServices.Vehicle
{
    public class CreateVehicle : ICreateVehicle
    {
        private readonly IUnitOfWork _uow;
        public CreateVehicle(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Guid> Execute(CreateVehicleViewModel create)
        {
            try
            {
                Domain.Entities.Vehicle Vehicle = create;

                Vehicle.SetOwnerId(create.OwnerId);
                Vehicle.SetBrandId(create.BrandId);

                var response = await _uow.VehicleRepository.Create(Vehicle);

                return response.Id;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Bad Request", nameof(e));
            }
        }
    }
}
