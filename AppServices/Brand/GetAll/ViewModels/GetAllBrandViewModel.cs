using AppServices.Enums;

namespace AppServices.Brand.GetAll.ViewModels
{
    public class GetAllBrandViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public BrandStatusEnum Status { get; set; }

        public static implicit operator GetAllBrandViewModel(Domain.Entities.Brand entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty Object", nameof(entity));
            }

            GetAllBrandViewModel brandViewModel = new GetAllBrandViewModel
            {
                Id = entity.Id,
                Name = entity.Name,
                CreateDate = entity.CreatedDate,
                Status = (BrandStatusEnum)entity.Status
            };

            return brandViewModel;
        }
    }
}
