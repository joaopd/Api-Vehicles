using AppServices.Vehicle.GetById.ViewModels;

namespace AppServices.Vehicle
{
    public interface IGetByIdVehicle
    {
        Task<GetByIdVehicleViewModel> Execute(Guid id);
    }
}
