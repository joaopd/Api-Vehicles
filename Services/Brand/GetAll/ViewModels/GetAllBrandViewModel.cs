using Services.Enums;

namespace Services.Brand.GetAll.ViewModels
{
    public class GetAllBrandViewModel
    {
        public Guid Id{ get; set; }
        public string Name{ get; set; }
        public DateTime CreateTime{ get; set; }
        public BrandStatusEnum Status { get; set; }

        public static implicit operator GetAllBrandViewModel (Domain.Entities.Brand entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty Object", nameof(entity));
            }

            GetAllBrandViewModel brandViewModel = new GetAllBrandViewModel
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
