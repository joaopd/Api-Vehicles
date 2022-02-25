using AppServices.Brand.GetAll.ViewModels;
using Domain.UoW;

namespace AppServices.Brand
{
    public class GetAllBrand : IGetAllBrand
    {
        private readonly IUnitOfWork _uow;
        public GetAllBrand(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<GetAllBrandViewModel>> Execute()
        {
            try
            {
                var response = await _uow.BrandRepository.GetList();

                if (response == null)
                    return null;

                var listBrandViewModel = new List<GetAllBrandViewModel>();

                foreach (var item in response)
                {
                    GetAllBrandViewModel brandViewModel = item;

                    listBrandViewModel.Add(brandViewModel);
                }

                return listBrandViewModel;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", nameof(e));
            }
        }
    }
}
