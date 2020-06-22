using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Caja.DTO.Response
{
    /// <summary>
    /// Creacion de item de movimiento
    /// </summary>
    public class CajaMovimientoResponse
    {
        /// <summary>
        /// Creacion de fecha
        /// </summary>
        public string dtInit { get; set; }

        /// <summary>
        /// Identificador de movimiento
        /// </summary>
        public Guid uidMovimiento { get; set; }

        /// <summary>
        /// Descripcion de tipo de movimiento
        /// </summary>
        public string tipoMovimiento { get; set; }

        /// <summary>
        /// Descripcion de forma de pago
        /// </summary>
        public string formaDePago { get; set; }
        /// <summary>
        /// Importe del pago
        /// </summary>
        public double dcimporte { get; set; }

        public string description { get; set; }
    }
}
