using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Base.DTO
{
    ///
    public class CError : System.Exception
    {
        ///
        public List<CErrorDet> ErrorDetails { get; set; }
        ///
        public CError()
        {
            ErrorDetails = new List<CErrorDet>();
        }
        ///
        public CError(CErrorDet error)
        {
            ErrorDetails = new List<CErrorDet> { error };
        }
    }
}
