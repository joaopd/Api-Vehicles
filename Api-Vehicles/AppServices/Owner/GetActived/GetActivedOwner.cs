using Domain.UoW;
using AppServices.Owner.GetActived.ViewModels;

namespace AppServices.Owner
{
    public class GetActivedOwner : IGetActivedOwner
    {
        private readonly IUnitOfWork _uow;
        public GetActivedOwner(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<GetActivedOwnerViewModel>> Execute()
        {
            try
            {
                var response = await _uow.OwnerRepository.GetList(expression: x => x.Status == Domain.Enums.OwnerStatusEnum.Actived);

                if (response == null)
                    return null;

                var listOwnerViewModel = new List<GetActivedOwnerViewModel>();

                foreach (var item in response)
                {
                    GetActivedOwnerViewModel OwnerViewModel = item;

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
