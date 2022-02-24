using Services.Brand.GetAll.ViewModels;

namespace Services.Brand.GetAll
{
    public interface IGetAllBrand
    {
        Task<IEnumerable<GetAllBrandViewModel>> Execute();
    }
}
