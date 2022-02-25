using AppServices.Owner;
using AppServices.Owner.Update.ViewModels;
using Domain.Interfaces;
using Domain.UoW;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppServicesTests.Owner
{
    public class UpdateTests : OwnerTests
    {
        private IUpdateOwner _service;
        private Mock<IUpdateOwner> _serviceMock;
        private ICreateOwner _crateService;
        private Mock<ICreateOwner> _crateServiceMock;

        [Fact(DisplayName = "Update_Is_ok")]
        public async Task Update_Is_Ok()
        {
            _serviceMock = new Mock<IUpdateOwner>();
            _serviceMock.Setup(x => x.Execute(updateOwnerModel)).ReturnsAsync(Id);
            _service = _serviceMock.Object;

            var result = await _service.Execute(updateOwnerModel);
            Assert.NotNull(result);
            Assert.True(result == Id);           
        }
    }
}
