using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Base.DTO
{
    ///
    public class CErrorDet : System.Exception
    {
        ///
        public string Origen { get; set; }
        ///
        public string Error { get; set; }
        ///
        public int IdTransaction { get; set; }
        ///
        public string ModelInformation { get; set; }
        ///
        public CErrorDet() : base() { }
        ///
        public CErrorDet(System.Exception inner) : base(string.Empty, inner) { }
        ///
        public CErrorDet(string message) : base(message) { }
        ///
        public CErrorDet(string message, System.Exception inner) : base(message, inner) { }
        ///
        public CErrorDet(string message, string origen) : base(message) { Origen = origen; }
        
    }
}
