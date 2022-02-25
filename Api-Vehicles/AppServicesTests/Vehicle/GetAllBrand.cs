using AppServices.Vehicle;
using AppServices.Vehicle.GetAll.ViewModels;
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
    public class GetAllTests : VehicleTests
    {
        private IGetAllVehicle _service;
        private Mock<IGetAllVehicle> _serviceMock;

        [Fact(DisplayName = "GetAll_Is_ok")]
        public async Task GetAll_Is_Ok()
        {
            _serviceMock = new Mock<IGetAllVehicle>();
            _serviceMock.Setup(x => x.Execute()).ReturnsAsync(listVehicleModel);
            _service = _serviceMock.Object;

            var result = await _service.Execute();
            Assert.NotNull(result);
            Assert.True(result.Count() ==10);

            var listResult = new List<GetAllVehicleViewModel>();

            _serviceMock = new Mock<IGetAllVehicle>();
            _serviceMock.Setup(x => x.Execute()).ReturnsAsync(listResult);
            _service = _serviceMock.Object;

            var _record = await _service.Execute();
            Assert.Empty(_record);
            Assert.True(_record.Count() == 0);

        }
    }
}
