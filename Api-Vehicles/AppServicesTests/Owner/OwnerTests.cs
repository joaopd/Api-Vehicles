using AppServices.Enums;
using AppServices.Owner._shared;
using AppServices.Owner.Create.ViewModels;
using AppServices.Owner.GetAll.ViewModels;
using AppServices.Owner.GetById.ViewModels;
using AppServices.Owner.Update.ViewModels;
using System;
using System.Collections.Generic;

namespace AppServicesTests.Owner
{
    public class OwnerTests
    {
        public Guid Id { get; set; }
        public static string Name { get; private set; }
        public static string Document { get; private set; }
        public static string Email { get; private set; }
        public static CreateAddressViewModel Address { get; private set; }
        public static string UpdateName { get; private set; }
        public static OwnerStatusEnum Status { get; private set; }

        public GetByIdOwnerViewModel OwnerModel;
        public List<GetAllOwnerViewModel> listOwnerModel = new List<GetAllOwnerViewModel>();
        public CreateOwnerViewModel createOwnerModel;
        public UpdateOwnerViewModel updateOwnerModel;

        public OwnerTests()
        {
            Id = Guid.NewGuid();
            Name = Faker.Name.FullName();
            UpdateName = Faker.Name.FullName();
            Status = OwnerStatusEnum.Actived;
            Document = "18032935193";
            Email = "Teste@tes.com";

            var getaddress = new GetAddressViewModel
            {
                Cep = "57305480",
                State = "AL",
                City = "Arapiraca",
                Neighborhood = "Baixão",
                Street = "Praça Coronel José de Farias"
            };

            var address = new CreateAddressViewModel
            {
                Cep = "57305480",
                State = "AL",
                City = "Arapiraca",
                Neighborhood = "Baixão",
                Street = "Praça Coronel José de Farias"
            };
            Address = address;

            for (int i = 0; i < 10; i++)
            {

                var model = new GetAllOwnerViewModel()
                {
                    Status = OwnerStatusEnum.Actived,
                    Name = Faker.Name.FullName(),
                    Address = getaddress,
                    Document = "18032935193",
                    Email = "Teste@tes.com",
                    Id = Guid.NewGuid()
                };
                listOwnerModel.Add(model);
            }

            createOwnerModel = new CreateOwnerViewModel()
            {
                Status = OwnerStatusEnum.Actived,
                Document = "18032935193",
                Email = "Teste@tes",
                Name = Faker.Name.FullName(),
                Address = address
            };

            OwnerModel = new GetByIdOwnerViewModel()
            {
                Address = getaddress,
                Document = Document,
                Email = Email,
                Status = Status,
                Name = Name,
                Id = Id,
                CreateDate = DateTime.UtcNow
            };

            updateOwnerModel = new UpdateOwnerViewModel()
            {
                Status = OwnerStatusEnum.Actived
            };
        }
    }
}
