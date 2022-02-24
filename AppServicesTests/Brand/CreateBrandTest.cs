//using ApiVehiclesTests.Brand.Builder;
//using AppServices.Brand;
//using Moq;
//using System;
//using System.Threading.Tasks;
//using Xunit;

//namespace ApiVehiclesTests.Ultils
//{
//    public class CreateBrandTest : CreateBrandBuilder
//    {
//        private ICreateBrand _service;
//        private Mock<ICreateBrand> _serviceMock;


//        [Fact(DisplayName = "E possivel executar Create ")]
//        public async Task E_Possivel_Excutar_Create()
//        {
//            _serviceMock = new Mock<ICreateBrand>();
//            _serviceMock.Setup(x => x.Set(_service.)).Returns(false);
//            _service = _serviceMock.Object;

//            var result = await _service.Post(userDtoCreate);
//            Assert.NotNull(result);
//            Assert.Equal(NomeUsuario, result.Name);
//            Assert.Equal(EmailUsuario, result.Email);
//        }
//    }
//}