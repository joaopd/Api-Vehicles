using Domain.Entities;
using Domain.Interfaces;
using Infraestructure.ApplicationDbContex;
using Infraestructure.Repository.BaseRepository;

namespace Infraestructure.Repository
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
