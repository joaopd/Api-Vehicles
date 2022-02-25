using AppServices.Brand.GetById.ViewModels;
using Domain.UoW;

namespace AppServices.Brand
{
    public class GetByIdBrand : IGetByIdBrand
    {
        private readonly IUnitOfWork _uow;
        public GetByIdBrand(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GetByIdBrandViewModel> Execute(Guid id)
        {
            try
            {
                var response = await _uow.BrandRepository.GetById(id);

                if (response == null)
                    return null;

                GetByIdBrandViewModel brandViewModel = response;

                return brandViewModel;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Not Found", e);
            }
        }
    }
}
