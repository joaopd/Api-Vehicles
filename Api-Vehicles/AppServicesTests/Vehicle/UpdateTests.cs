using AppServices.Vehicle;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace AppServicesTests.Vehicle
{
    public class UpdateTests : VehicleTests
    {
        private IUpdateVehicle _service;
        private Mock<IUpdateVehicle> _serviceMock;

        [Fact(DisplayName = "Update_Is_ok")]
        public async Task Update_Is_Ok()
        {
            _serviceMock = new Mock<IUpdateVehicle>();
            _serviceMock.Setup(x => x.Execute(updateVehicleModel)).ReturnsAsync(Id);
            _service = _serviceMock.Object;

            var result = await _service.Execute(updateVehicleModel);
            Assert.NotNull(result);
            Assert.True(result == Id);
        }
    }
}
