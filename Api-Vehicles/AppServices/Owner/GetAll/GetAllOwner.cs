using Domain.UoW;
using AppServices.Owner.GetAll.ViewModels;

namespace AppServices.Owner
{
    public class GetAllOwner : IGetAllOwner
    {
        private readonly IUnitOfWork _uow;
        public GetAllOwner(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<GetAllOwnerViewModel>> Execute()
        {
            try
            {
                var response = await _uow.OwnerRepository.GetList();

                if (response == null)
                    return null;

                var listOwnerViewModel = new List<GetAllOwnerViewModel>();

                foreach (var item in response)
                {
                    GetAllOwnerViewModel OwnerViewModel = item;

                    listOwnerViewModel.Add(OwnerViewModel);
                }

                return listOwnerViewModel;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }
    }
}
