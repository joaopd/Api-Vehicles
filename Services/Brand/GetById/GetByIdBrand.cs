using Domain.UoW;
using Infraestructure.ApplicationDbContex;
using Services.Brand.GetById.ViewModels;

namespace Services.Brand
{
    public class GetByIdBrand :  IGetByIdBrand
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
            catch (Exception)
            {
                throw new ArgumentNullException("Not Found");
            }
        }
    }
}
