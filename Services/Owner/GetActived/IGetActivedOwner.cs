using Services.Owner.GetActived.ViewModels;

namespace Services.Owner.GetActived
{
    public interface IGetActivedOwner
    {
        Task<IEnumerable<GetActivedOwnerViewModel>> Execute();
    }
}
