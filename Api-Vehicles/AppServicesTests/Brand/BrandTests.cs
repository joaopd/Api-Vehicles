using AppServices.Brand.Create.ViewModels;
using AppServices.Brand.GetAll.ViewModels;
using AppServices.Brand.GetById.ViewModels;
using AppServices.Brand.Update.ViewModels;
using AppServices.Enums;
using System;
using System.Collections.Generic;

namespace AppServicesTests.Brand
{
    public class BrandTests
    {
        public Guid Id { get; set; }
        public static string Name { get; private set; }
        public static string UpdateName { get; private set; }
        public static BrandStatusEnum Status { get; private set; }

        public GetByIdBrandViewModel brandModel;
        public List<GetAllBrandViewModel> listBrandModel = new List<GetAllBrandViewModel>();
        public CreateBrandViewModel createBrandModel;
        public UpdateBrandViewModel updatebrandModel;

        public BrandTests()
        {
            Id = Guid.NewGuid();
            Name = Faker.Name.FullName();
            UpdateName = Faker.Name.FullName();
            Status = BrandStatusEnum.Actived;

            for (int i = 0; i < 10; i++)
            {
                var model = new GetAllBrandViewModel()
                {
                    Status = BrandStatusEnum.Actived,
                    Name = Faker.Name.FullName(),
                    Id = Guid.NewGuid()
                };
                listBrandModel.Add(model);
            }

            createBrandModel = new CreateBrandViewModel()
            {
                Name = Faker.Name.FullName(),
                Status = BrandStatusEnum.Actived
            };

            brandModel = new GetByIdBrandViewModel()
            {
                Status = Status,
                Name = Name,
                Id = Id,
                CreateDate = DateTime.UtcNow
            };

            updatebrandModel = new UpdateBrandViewModel()
            {
                Status = BrandStatusEnum.Actived
            };
        }
    }
}
