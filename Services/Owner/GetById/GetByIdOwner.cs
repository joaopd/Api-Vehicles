using Domain.UoW;
using Services.Owner.GetById.ViewModels;

namespace Services.Owner
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
            catch (Exception)
            {
                throw new ArgumentNullException("Not Found");
            }
        }
    }
}
