using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Recibos.DTO.Request
{
    public class CajaMovimientoRequest
    {
        public Guid uidcompany { get; set; }
        public Guid uidTipoMovimiento { get; set; }
        public Guid uidFormaPago { get; set; }
        public Guid uidUser { get; set; }
        public string uidRecibos { get; set; }
    }
}
