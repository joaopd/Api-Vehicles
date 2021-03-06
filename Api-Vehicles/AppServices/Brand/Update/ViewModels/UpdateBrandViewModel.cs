using AppServices.Enums;

namespace AppServices.Brand.Update.ViewModels
{
    public class UpdateBrandViewModel
    {
        public Guid Id { get; set; }
        public BrandStatusEnum Status { get; set; }

        public static implicit operator Domain.Entities.Brand(UpdateBrandViewModel viewModel)
        {
            if (viewModel == null)
            {
                throw new ArgumentNullException("Not Found", nameof(viewModel));
            }

            var brand = new Domain.Entities.Brand();

            brand.SetStatus((Domain.Enums.BrandStatusEnum)viewModel.Status);

            brand.Id = viewModel.Id;

            return brand;
        }
    }
}
