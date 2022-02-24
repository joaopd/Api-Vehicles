using Services.Brand.GetAll.ViewModels;

namespace Services.Brand
{
    public interface IGetAllBrand
    {
        Task<IEnumerable<GetAllBrandViewModel>> Execute();
    }
}
