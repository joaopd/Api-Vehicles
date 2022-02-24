using Services.Owner.GetById.ViewModels;

namespace Services.Owner.GetById
{
    public interface IGetByIdOwner
    {
        Task<GetByIdOwnerViewModel> Execute(Guid id);
    }
}
