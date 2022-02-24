using Services.Brand.GetActived.ViewModels;

namespace Services.Brand
{
    public interface IGetActivedBrand
    {
        Task<IEnumerable<GetActivedBrandViewModel>> Execute();
    }
}
