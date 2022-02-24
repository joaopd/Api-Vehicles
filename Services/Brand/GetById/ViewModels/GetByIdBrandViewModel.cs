using Services.Enums;

namespace Services.Brand.GetById.ViewModels
{
    public class GetByIdBrandViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public BrandStatusEnum Status { get; set; }

        public static implicit operator GetByIdBrandViewModel(Domain.Entities.Brand entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Objeto Vazio", nameof(entity));
            }

            GetByIdBrandViewModel brandViewModel = new GetByIdBrandViewModel
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
