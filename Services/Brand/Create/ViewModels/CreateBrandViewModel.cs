using Services.Enums;

namespace Services.Brand.Create.ViewModels
{
    public class CreateBrandViewModel
    {
        public string Name { get; set; }
        public BrandStatusEnum Status { get; set; }

        public static implicit operator Domain.Entities.Brand(CreateBrandViewModel viewModel)
        {
            if (viewModel == null)
            {
                throw new ArgumentNullException("Not Found", nameof(viewModel));
            }

            var brand = new Domain.Entities.Brand(viewModel.Name, (Domain.Enums.BrandStatusEnum)viewModel.Status);

            return brand;
        }
    }
}
