using AppServices.Vehicle;
using AppServices.Vehicle.Create.ViewModels;
using Domain.Interfaces;
using Domain.UoW;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppServicesTests.Vehicle
{
    public class CreateTests : VehicleTests
    {
        private ICreateVehicle _service;
        private Mock<ICreateVehicle> _serviceMock;

        [Fact(DisplayName = "Create_Is_ok")]
        public async Task Create_Is_Ok()
        {
            _serviceMock = new Mock<ICreateVehicle>();
            _serviceMock.Setup(x => x.Execute(createVehicleModel)).ReturnsAsync(Id);
            _service = _serviceMock.Object;

            var result = await _service.Execute(createVehicleModel);
            Assert.NotNull(result);
            Assert.True(result == Id);
        }
    }
}
