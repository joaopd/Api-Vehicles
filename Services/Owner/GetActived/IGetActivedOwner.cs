using Services.Owner.GetActived.ViewModels;

namespace Services.Owner
{
    public interface IGetActivedOwner
    {
        Task<IEnumerable<GetActivedOwnerViewModel>> Execute();
    }
}
