using Services.Owner.GetById.ViewModels;

namespace Services.Owner
{
    public interface IGetByIdOwner
    {
        Task<GetByIdOwnerViewModel> Execute(Guid id);
    }
}
