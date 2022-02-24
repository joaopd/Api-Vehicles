using Services.Enums;

namespace Services.Brand.GetActived.ViewModels
{
    public class GetActivedBrandViewModel
    {
        public Guid Id{ get; set; }
        public string Name{ get; set; }
        public DateTime CreateTime{ get; set; }
        public BrandStatusEnum Status { get; set; }

        public static implicit operator GetActivedBrandViewModel (Domain.Entities.Brand entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty Object", nameof(entity));
            }

            GetActivedBrandViewModel brandViewModel = new GetActivedBrandViewModel
            {
                Id = entity.Id,
                Name = entity.Name,
                CreateTime = entity.CreatedDate,
                Status = (BrandStatusEnum)entity.Status
            };

            return brandViewModel;
        }
    }
}
