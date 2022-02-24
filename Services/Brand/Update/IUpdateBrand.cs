using Services.Brand.Update.ViewModels;

namespace Services.Brand.Update
{
    public interface IUpdateBrand
    {
        Task<Guid> Execute(UpdateBrandViewModel update);
    }
}
