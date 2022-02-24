using Services.Enums;

namespace Services.Brand.Update.ViewModels
{
    public class UpdateBrandViewModel
    {
        public BrandStatusEnum Status { get; set; }

        public static implicit operator Domain.Entities.Brand(UpdateBrandViewModel viewModel)
        {
            if (viewModel == null)
            {
                throw new ArgumentNullException("Objeto Vazio", nameof(viewModel));
            }

            var brand = new Domain.Entities.Brand();

            brand.SetStatus((Domain.Enums.BrandStatusEnum)viewModel.Status);

            return brand;
        }
    }
}
