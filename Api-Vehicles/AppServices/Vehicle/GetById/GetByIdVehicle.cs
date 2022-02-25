using AppServices.Vehicle.GetById.ViewModels;
using Domain.UoW;
using Microsoft.EntityFrameworkCore;

namespace AppServices.Vehicle
{
    public class GetByIdVehicle : IGetByIdVehicle
    {
        private readonly IUnitOfWork _uow;
        public GetByIdVehicle(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GetByIdVehicleViewModel> Execute(Guid id)
        {
            try
            {
                var response = (await _uow.VehicleRepository.GetList(x => x.Id.Equals(id), x => x.Include(p => p.Brand)
                                                                                                .Include(p => p.Owner))).FirstOrDefault();
                if (response == null)
                    return null;

                GetByIdVehicleViewModel VehicleViewModel = response;

                return VehicleViewModel;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }
    }
}
