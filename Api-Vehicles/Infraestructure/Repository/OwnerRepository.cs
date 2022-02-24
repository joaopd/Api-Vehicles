using Domain.Entities;
using Domain.Interfaces;
using Infraestructure.ApplicationDbContex;
using Infraestructure.Repository.BaseRepository;

namespace Infraestructure.Repository
{
    public class OwnerRepository : BaseRepository<Owner>, IOwnerRepository
    {
        public OwnerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
