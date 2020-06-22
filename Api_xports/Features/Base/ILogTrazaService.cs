using Api_xports.Features.Base.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Base
{
    ///
    public interface ILogTrazaService
    {
        ///
       void AddErrorTransaction(CError error);

    }
}
