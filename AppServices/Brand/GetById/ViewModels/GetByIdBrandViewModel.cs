using AppServices.Enums;

namespace AppServices.Brand.GetById.ViewModels
{
    public class GetByIdBrandViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public BrandStatusEnum Status { get; set; }

        public static implicit operator GetByIdBrandViewModel(Domain.Entities.Brand entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Not Found", nameof(entity));
            }

            GetByIdBrandViewModel brandViewModel = new GetByIdBrandViewModel
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
