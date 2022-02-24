using Services.Brand.GetActived.ViewModels;

namespace Services.Brand.GetActived
{
    public interface IGetActivedBrand
    {
        Task<IEnumerable<GetActivedBrandViewModel>> Execute();
    }
}
