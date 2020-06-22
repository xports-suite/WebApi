using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Recibos.DTO.Response
{
    public class GetRecibosByUIDPersonRequest
    {
        public Guid uidRecibo { get; set; }
        public Guid uidReserva { get; set; }
        public Guid? uidProjectFase { get; set; }
        public Guid? uidProducto { get; set; }

        public string descripcion { get; set; }

        public double dimporteUnitario { get; set; }

        public int iunidades { get; set; }

        public double dimporteTotal { get; set; }

        public string estadoRecibo { get; set; }

        public DateTime fechaRecibo { get; set; }

        public double dtotalRecibo { get; set; }

        public double dimportePagado { get; set; }
        public double dimportePendiente { get; set; }
    }
}
