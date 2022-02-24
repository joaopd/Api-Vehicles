using Services.Brand.Create.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Brand.Create
{
    public interface ICreateBrand
    {
        Task<Guid> Execute(CreateBrandViewModel create);
    }
}
