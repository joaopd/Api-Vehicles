using Domain.UoW;
using Microsoft.EntityFrameworkCore;
using AppServices.Vehicle.GetAll.ViewModels;

namespace AppServices.Vehicle
{
    public class GetAllVehicle : IGetAllVehicle
    {
        private readonly IUnitOfWork _uow;
        public GetAllVehicle(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<GetAllVehicleViewModel>> Execute()
        {
            try
            {
                var response = await _uow.VehicleRepository.GetList(include: x => x.Include(p => p.Brand)
                                                                                   .Include(p => p.Owner));

                if (response == null)
                    return null;

                var listVehicleViewModel = new List<GetAllVehicleViewModel>();

                foreach (var item in response)
                {
                    GetAllVehicleViewModel VehicleViewModel = item;

                    listVehicleViewModel.Add(VehicleViewModel);
                }

                return listVehicleViewModel;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }
    }
}
