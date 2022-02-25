using AppServices.Owner.GetById.ViewModels;
using Domain.UoW;

namespace AppServices.Owner
{
    public class GetByIdOwner : IGetByIdOwner
    {
        private readonly IUnitOfWork _uow;
        public GetByIdOwner(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GetByIdOwnerViewModel> Execute(Guid id)
        {
            try
            {
                var response = await _uow.OwnerRepository.GetById(id);

                if (response == null)
                    return null;

                GetByIdOwnerViewModel OwnerViewModel = response;

                return OwnerViewModel;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }
    }
}
