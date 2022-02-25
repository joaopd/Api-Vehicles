using AppServices.Owner;
using AppServices.Owner.GetAll.ViewModels;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AppServicesTests.Owner
{
    public class GetAllTests : OwnerTests
    {
        private IGetAllOwner _service;
        private Mock<IGetAllOwner> _serviceMock;

        [Fact(DisplayName = "GetAll_Is_ok")]
        public async Task GetAll_Is_Ok()
        {
            _serviceMock = new Mock<IGetAllOwner>();
            _serviceMock.Setup(x => x.Execute()).ReturnsAsync(listOwnerModel);
            _service = _serviceMock.Object;

            var result = await _service.Execute();
            Assert.NotNull(result);
            Assert.True(result.Count() == 10);

            var listResult = new List<GetAllOwnerViewModel>();

            _serviceMock = new Mock<IGetAllOwner>();
            _serviceMock.Setup(x => x.Execute()).ReturnsAsync(listResult);
            _service = _serviceMock.Object;

            var _record = await _service.Execute();
            Assert.Empty(_record);
            Assert.True(_record.Count() == 0);

        }
    }
}
