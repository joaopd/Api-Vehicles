using AppServices.Brand.GetActived.ViewModels;

namespace AppServices.Brand
{
    public interface IGetActivedBrand
    {
        Task<IEnumerable<GetActivedBrandViewModel>> Execute();
    }
}
