using AppServices.Brand.Create.ViewModels;

namespace AppServices.Brand
{
    public interface ICreateBrand
    {
        Task<Guid> Execute(CreateBrandViewModel create);
    }
}
