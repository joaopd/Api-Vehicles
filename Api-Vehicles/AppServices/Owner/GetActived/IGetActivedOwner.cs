using AppServices.Owner.GetActived.ViewModels;

namespace AppServices.Owner
{
    public interface IGetActivedOwner
    {
        Task<IEnumerable<GetActivedOwnerViewModel>> Execute();
    }
}
