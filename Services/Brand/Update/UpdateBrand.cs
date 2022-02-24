﻿using Domain.UoW;
using Infraestructure.ApplicationDbContex;
using Services.Brand.Update.ViewModels;

namespace Services.Brand.Update
{
    public class UpdateBrand :  IUpdateBrand
    {
        private readonly IUnitOfWork _uow;
        public UpdateBrand(IUnitOfWork uow)
        {
            _uow = uow;
        }     

        public async Task<Guid> Execute(UpdateBrandViewModel Update)
        {
            try
            {
                Domain.Entities.Brand brand = Update;

                var response = await _uow.BrandRepository.Update(brand);

                return response.Id;
            }
            catch (Exception)
            {
                throw new ArgumentNullException("Bad Request");
            }
        }
    }
}
