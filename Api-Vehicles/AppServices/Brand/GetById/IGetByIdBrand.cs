using AppServices.Brand.GetById.ViewModels;

namespace AppServices.Brand
{
    public interface IGetByIdBrand
    {
        Task<GetByIdBrandViewModel> Execute(Guid id);
    }
}
