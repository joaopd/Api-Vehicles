using Services.Owner.Create.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Owner.Create
{
    public interface ICreateOwner
    {
        Task<Guid> Execute(CreateOwnerViewModel create);
    }
}
