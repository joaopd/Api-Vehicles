using AppServices.Brand.GetAll.ViewModels;

namespace AppServices.Brand
{
    public interface IGetAllBrand
    {
        Task<IEnumerable<GetAllBrandViewModel>> Execute();
    }
}
