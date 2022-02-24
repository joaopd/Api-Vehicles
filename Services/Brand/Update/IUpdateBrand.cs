using Services.Brand.Update.ViewModels;

namespace Services.Brand
{
    public interface IUpdateBrand
    {
        Task<Guid> Execute(UpdateBrandViewModel update);
    }
}
