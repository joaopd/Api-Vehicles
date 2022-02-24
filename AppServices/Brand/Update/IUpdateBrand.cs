using AppServices.Brand.Update.ViewModels;

namespace AppServices.Brand
{
    public interface IUpdateBrand
    {
        Task<Guid> Execute(UpdateBrandViewModel update);
    }
}
