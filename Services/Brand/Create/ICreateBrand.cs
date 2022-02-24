using Services.Brand.Create.ViewModels;

namespace Services.Brand
{
    public interface ICreateBrand
    {
        Task<Guid> Execute(CreateBrandViewModel create);
    }
}
