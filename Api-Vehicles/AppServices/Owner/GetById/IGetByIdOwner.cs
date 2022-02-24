using AppServices.Owner.GetById.ViewModels;

namespace AppServices.Owner
{
    public interface IGetByIdOwner
    {
        Task<GetByIdOwnerViewModel> Execute(Guid id);
    }
}
