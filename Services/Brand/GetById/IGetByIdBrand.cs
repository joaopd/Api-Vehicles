using Services.Brand.GetById.ViewModels;

namespace Services.Brand.GetById
{
    public interface IGetByIdBrand
    {
        Task<GetByIdBrandViewModel> Execute(Guid id);
    }
}
