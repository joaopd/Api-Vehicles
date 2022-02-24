using Services.Owner.Update.ViewModels;

namespace Services.Owner
{
    public interface IUpdateOwner
    {
        Task<Guid> Execute(UpdateOwnerViewModel update);
    }
}
