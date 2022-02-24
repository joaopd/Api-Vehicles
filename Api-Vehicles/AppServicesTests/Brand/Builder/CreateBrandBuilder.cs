using AppServices.Brand.Create.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiVehiclesTests.Brand.Builder
{
    public class CreateBrandBuilder
    {
        public static CreateBrandViewModel CreateDefault()
        {
            return new CreateBrandViewModel
            {
                Status = AppServices.Enums.BrandStatusEnum.Actived,                
                Name = "test"
            };
        }

        public static CreateBrandViewModel CreateInvalid()
        {
            return new CreateBrandViewModel();
        }
    }
}
