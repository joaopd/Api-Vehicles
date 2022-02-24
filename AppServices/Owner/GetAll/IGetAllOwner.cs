using AppServices.Owner.GetAll.ViewModels;

namespace AppServices.Owner
{
    public interface IGetAllOwner
    {
        Task<IEnumerable<GetAllOwnerViewModel>> Execute();
    }
}
