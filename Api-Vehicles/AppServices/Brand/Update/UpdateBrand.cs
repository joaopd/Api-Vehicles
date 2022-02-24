using Domain.UoW;
using AppServices.Brand.Update.ViewModels;

namespace AppServices.Brand
{
    public class UpdateBrand : IUpdateBrand
    {
        private readonly IUnitOfWork _uow;
        public UpdateBrand(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Guid> Execute(UpdateBrandViewModel Update)
        {
            try
            {
                Domain.Entities.Brand brand = Update;

                var getBrand = await _uow.BrandRepository.GetById(Update.Id);

                if (getBrand == null)
                    throw new ArgumentNullException("Not Found");

                brand.SetName(getBrand.Name);

                var response = await _uow.BrandRepository.Update(brand);

                return response.Id;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Bad Request", nameof(e));
            }
        }
    }
}
