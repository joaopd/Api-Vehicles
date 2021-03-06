using AppServices.Owner.Update.ViewModels;
using Domain.UoW;

namespace AppServices.Owner
{
    public class UpdateOwner : IUpdateOwner
    {
        private readonly IUnitOfWork _uow;
        public UpdateOwner(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Guid> Execute(UpdateOwnerViewModel Update)
        {
            try
            {
                Domain.Entities.Owner Owner = Update;

                var response = await _uow.OwnerRepository.Update(Owner);

                return response.Id;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Bad Request", nameof(e));
            }
        }
    }
}
