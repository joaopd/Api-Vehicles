using AppServices.Vehicle.GetAll.ViewModels;

namespace AppServices.Vehicle
{
    public interface IGetAllVehicle
    {
        Task<IEnumerable<GetAllVehicleViewModel>> Execute();
    }
}
