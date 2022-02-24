using AppServices.Owner.Create.ViewModels;

namespace AppServices.Owner
{
    public interface ICreateOwner
    {
        Task<Guid> Execute(CreateOwnerViewModel create);
    }
}
