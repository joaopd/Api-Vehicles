using AppServices.Vehicle.Create.ViewModels;

namespace AppServices.Vehicle
{
    public interface ICreateVehicle
    {
        Task<Guid> Execute(CreateVehicleViewModel create);
    }
}
