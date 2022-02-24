using AppServices.Owner.Update.ViewModels;

namespace AppServices.Owner
{
    public interface IUpdateOwner
    {
        Task<Guid> Execute(UpdateOwnerViewModel update);
    }
}
