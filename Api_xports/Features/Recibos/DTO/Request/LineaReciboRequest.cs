using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Recibos.DTO.Request
{
    public class LineaReciboRequest
    {
        public Guid uidRecibo { get; set; }
        public Guid uidProducto { get; set; }
        public string descripcion { get; set; }
        public double dcImporteUnitario { get; set; }
        public int iUnidades { get; set; }
    }
}
