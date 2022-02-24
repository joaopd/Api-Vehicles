using Domain.Entities;
using Domain.Interfaces;
using Infraestructure.ApplicationDbContex;
using Infraestructure.Repository.BaseRepository;

namespace Infraestructure.Repository
{
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {
        public BrandRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
