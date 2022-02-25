using AppServices.Vehicle;
using AppServices.Vehicle.GetById.ViewModels;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AppServicesTests.Vehicle
{
    public class GetByIdTests : VehicleTests
    {
        private IGetByIdVehicle _service;
        private Mock<IGetByIdVehicle> _serviceMock;

        [Fact(DisplayName = "GetById_Is_ok")]
        public async Task GetById_Is_Ok()
        {
            _serviceMock = new Mock<IGetByIdVehicle>();
            _serviceMock.Setup(x => x.Execute(Id)).ReturnsAsync(VehicleModel);
            _service = _serviceMock.Object;

            var result = await _service.Execute(Id);
            Assert.NotNull(result);
            Assert.True(result.Id == Id);

            _serviceMock = new Mock<IGetByIdVehicle>();
            _serviceMock.Setup(x => x.Execute(It.IsAny<Guid>())).Returns(Task.FromResult((GetByIdVehicleViewModel)null));
            _service = _serviceMock.Object;

            var _record = await _service.Execute(Id);
            Assert.Null(_record);
        }
    }
}
