using Domain.UoW;
using Infraestructure.ApplicationDbContex;
using Services.Brand.Create.ViewModels;

namespace Services.Brand.Create
{
    public class CreateBrand :  ICreateBrand
    {
        private readonly IUnitOfWork _uow;
        public CreateBrand(IUnitOfWork uow)
        {
            _uow = uow;
        }     

        public async Task<Guid> Execute(CreateBrandViewModel create)
        {
            try
            {
                Domain.Entities.Brand brand = create;

                var response = await _uow.BrandRepository.Create(brand);

                return response.Id;
            }
            catch (Exception)
            {
                throw new ArgumentNullException("Não foi possivel efetuar o cadastro");
            }
        }
    }
}
