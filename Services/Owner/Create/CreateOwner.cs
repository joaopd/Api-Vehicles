using Domain.UoW;
using Services.Owner.Create.ViewModels;

namespace Services.Owner
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
            catch (Exception)
            {
                throw new ArgumentNullException("Bad Request");
            }
        }
    }
}
