using AppServices.Brand;
using AppServices.Brand.GetById.ViewModels;
using Domain.Interfaces;
using Domain.UoW;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppServicesTests.Brand
{
    public class GetByIdTests : BrandTests
    {
        private IGetByIdBrand _service;
        private Mock<IGetByIdBrand> _serviceMock;

        [Fact(DisplayName = "GetById_Is_ok")]
        public async Task GetById_Is_Ok()
        {
            _serviceMock = new Mock<IGetByIdBrand>();
            _serviceMock.Setup(x => x.Execute(Id)).ReturnsAsync(brandModel);
            _service = _serviceMock.Object;

            var result = await _service.Execute(Id);
            Assert.NotNull(result);
            Assert.True(result.Id == Id);
            Assert.Equal(Name, result.Name);

            _serviceMock = new Mock<IGetByIdBrand>();
            _serviceMock.Setup(x => x.Execute(It.IsAny<Guid>())).Returns(Task.FromResult((GetByIdBrandViewModel)null));
            _service = _serviceMock.Object;

            var _record = await _service.Execute(Id);
            Assert.Null(_record);         
        }
    }
}
