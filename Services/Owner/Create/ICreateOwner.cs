using Services.Owner.Create.ViewModels;

namespace Services.Owner
{
    public interface ICreateOwner
    {
        Task<Guid> Execute(CreateOwnerViewModel create);
    }
}
