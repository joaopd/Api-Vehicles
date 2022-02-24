using Services.Owner.GetAll.ViewModels;

namespace Services.Owner.GetAll
{
    public interface IGetAllOwner
    {
        Task<IEnumerable<GetAllOwnerViewModel>> Execute();
    }
}
