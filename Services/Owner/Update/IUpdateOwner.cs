using Services.Owner.Update.ViewModels;

namespace Services.Owner.Update
{
    public interface IUpdateOwner
    {
        Task<Guid> Execute(UpdateOwnerViewModel update);
    }
}
