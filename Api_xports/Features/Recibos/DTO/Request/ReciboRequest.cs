using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Recibos.DTO.Request
{
    public class ReciboRequest
    {
        public Guid uidPerson { get; set; }

        public Guid uiReserva { get; set; }
    }
}
