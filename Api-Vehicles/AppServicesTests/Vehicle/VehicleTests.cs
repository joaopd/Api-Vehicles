using AppServices.Enums;
using AppServices.Vehicle.Create.ViewModels;
using AppServices.Vehicle.GetAll.ViewModels;
using AppServices.Vehicle.GetById.ViewModels;
using AppServices.Vehicle.Updates.ViewModels;
using System;
using System.Collections.Generic;

namespace AppServicesTests.Vehicle
{
    public class VehicleTests
    {
        public Guid Id { get; set; }
        public static string Name { get; private set; }
        public static string Document { get; private set; }
        public static string Email { get; private set; }
        public static string UpdateName { get; private set; }
        public static VehicleStatusEnum Status { get; private set; }

        public GetByIdVehicleViewModel VehicleModel;
        public List<GetAllVehicleViewModel> listVehicleModel = new List<GetAllVehicleViewModel>();
        public CreateVehicleViewModel createVehicleModel;
        public UpdateVehicleViewModel updateVehicleModel;

        public VehicleTests()
        {
            Id = Guid.NewGuid();
            Name = Faker.Name.FullName();
            UpdateName = Faker.Name.FullName();
            Status = VehicleStatusEnum.Available;
            Document = "18032935193";
            Email = "Teste@tes.com";

            for (int i = 0; i < 10; i++)
            {

                var model = new GetAllVehicleViewModel()
                {
                    Status = VehicleStatusEnum.Available,

                    Id = Guid.NewGuid()
                };
                listVehicleModel.Add(model);
            }

            createVehicleModel = new CreateVehicleViewModel()
            {
                Status = VehicleStatusEnum.Available,

            };

            VehicleModel = new GetByIdVehicleViewModel()
            {
                Status = Status,
                Id = Id,
                CreateDate = DateTime.UtcNow
            };

            updateVehicleModel = new UpdateVehicleViewModel()
            {
                Status = VehicleStatusEnum.Available
            };
        }
    }
}
