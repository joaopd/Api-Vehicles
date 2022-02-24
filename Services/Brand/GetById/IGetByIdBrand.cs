using Services.Brand.GetById.ViewModels;

namespace Services.Brand
{
    public interface IGetByIdBrand
    {
        Task<GetByIdBrandViewModel> Execute(Guid id);
    }
}
