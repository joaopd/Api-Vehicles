using Domain.Interfaces;
using Domain.UoW;
using Infraestructure.ApplicationDbContex;
using Infraestructure.Repository;

namespace Infraestructure.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        private IBrandRepository _IBrandRepository;
        private IVehicleRepository _IVehicleRepository;
        private IOwnerRepository _IOwnerRepository;

        public IBrandRepository BrandRepository
        {
            get
            {
                if (_IBrandRepository == null) { _IBrandRepository = new BrandRepository(_context); }
                return _IBrandRepository;
            }
        }
        public IVehicleRepository VehicleRepository
        {
            get
            {
                if (_IVehicleRepository == null) { _IVehicleRepository = new VehicleRepository(_context); }
                return _IVehicleRepository;
            }
        }
        public IOwnerRepository OwnerRepository
        {
            get
            {
                if (_IOwnerRepository == null) { _IOwnerRepository = new OwnerRepository(_context); }
                return _IOwnerRepository;
            }
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
