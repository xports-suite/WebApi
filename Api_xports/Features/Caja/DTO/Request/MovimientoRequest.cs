using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Caja.DTO.Request
{
    /// <summary>
    /// Entida que representa la Inserccion o modificacion de un moviento de caja
    /// </summary>
    public class MovimientoRequest
    {
        /// <summary>
        /// Identificador del movmiento
        /// </summary>
        public string uicompany { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string descripcion { get; set; }


        /// <summary>
        /// Importe de Apertura
        /// </summary>
        public double importe { get; set; }

        /// <summary>
        /// Importe Pago
        /// </summary>
        public string uidtipoMovimiento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string uiperson { get; set; }

    }
}
