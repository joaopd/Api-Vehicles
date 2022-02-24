using Domain.UoW;
using Infraestructure.ApplicationDbContex;
using Services.Brand.GetActived.ViewModels;

namespace Services.Brand.GetActived
{
    public class GetActivedBrand :  IGetActivedBrand
    {
        private readonly IUnitOfWork _uow;
        public GetActivedBrand(IUnitOfWork uow)
        {
            _uow = uow;
        }     

        public async Task<IEnumerable<GetActivedBrandViewModel>> Execute()
        {
            try
            {                
                var response = await _uow.BrandRepository.GetList(expression: x => x.Status == Domain.Enums.BrandStatusEnum.Actived);

                if (response == null)
                    return null;

                var listBrandViewModel = new List<GetActivedBrandViewModel>();

                foreach (var item in response)
                {
                    GetActivedBrandViewModel brandViewModel = item;

                    listBrandViewModel.Add(brandViewModel);
                }

                return listBrandViewModel;
            }
            catch (Exception)
            {
                throw new ArgumentNullException("Not Found");
            }
        }
    }
}
