﻿using AppServices.Brand;
using AppServices.Brand.Update.ViewModels;
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
    public class UpdateTests : BrandTests
    {
        private IUpdateBrand _service;
        private Mock<IUpdateBrand> _serviceMock;
        private ICreateBrand _crateService;
        private Mock<ICreateBrand> _crateServiceMock;

        [Fact(DisplayName = "Update_Is_ok")]
        public async Task Update_Is_Ok()
        {
            _serviceMock = new Mock<IUpdateBrand>();
            _serviceMock.Setup(x => x.Execute(updatebrandModel)).ReturnsAsync(Id);
            _service = _serviceMock.Object;

            var result = await _service.Execute(updatebrandModel);
            Assert.NotNull(result);
            Assert.True(result == Id);           
        }
    }
}
