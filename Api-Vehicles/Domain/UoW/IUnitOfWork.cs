using Domain.Interfaces;

namespace Domain.UoW
{
    public interface IUnitOfWork
    {
        void Commit();

        public IBrandRepository BrandRepository { get; }
        public IOwnerRepository OwnerRepository { get; }
        public IVehicleRepository VehicleRepository { get; }
    }
}
