using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Caja.DTO.Response
{
    public class CajaSituacionResponse
    {
        public DateTime dtInit { get; set; }

        public double dcApertura { get; set; }

        public double dcMetalico { get; set; }

        public double dcTarjeta { get; set; }

        public double dcRetirado { get; set; }

        public double dcCierre { get; set; }

        public double dcIngresos { get; set; }

        public double dcPagos { get; set; }

        public double dcDescuadre { get; set; }
    }
}
