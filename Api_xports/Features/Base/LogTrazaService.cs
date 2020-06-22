using Api_xports.Features.Base.DTO;
using Api_xports.Features.Base.Validation;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api_xports.Features.Base
{
    ///
    public class LogTrazaService : ILogTrazaService
    {
        ///
        private IUnitOfWork _unitOfWork;
        ///
        public LogTrazaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        ///

        public void AddErrorTransaction(CError error)
        {
            throw new NotImplementedException();
        }
    }
}
