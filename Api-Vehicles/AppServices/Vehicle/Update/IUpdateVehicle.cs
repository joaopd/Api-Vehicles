using AppServices.Vehicle.Updates.ViewModels;

namespace AppServices.Vehicle
{
    public interface IUpdateVehicle
    {
        Task<Guid> Execute(UpdateVehicleViewModel update);
    }
}
