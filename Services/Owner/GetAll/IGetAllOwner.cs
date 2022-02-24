using Services.Owner.GetAll.ViewModels;

namespace Services.Owner
{
    public interface IGetAllOwner
    {
        Task<IEnumerable<GetAllOwnerViewModel>> Execute();
    }
}
