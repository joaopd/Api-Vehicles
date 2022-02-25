using AppServices.Owner.Create.ViewModels;
using Domain.UoW;

namespace AppServices.Owner
{
    public class CreateOwner : ICreateOwner
    {
        private readonly IUnitOfWork _uow;
        public CreateOwner(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Guid> Execute(CreateOwnerViewModel create)
        {
            try
            {
                Domain.Entities.Owner Owner = create;

                var response = await _uow.OwnerRepository.Create(Owner);

                return response.Id;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Bad Request", nameof(e));
            }
        }
    }
}
