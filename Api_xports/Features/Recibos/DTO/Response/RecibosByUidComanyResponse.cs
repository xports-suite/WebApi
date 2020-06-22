using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Recibos.DTO.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class RecibosByUidComanyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid uidRecibo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string estadoRecibo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string usuario { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? dtFechaAlta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? dtFechaBaja { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? dtFechaPago { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double dcImporteTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double dcImportePagado { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double dcImportePendiente { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string formaPago { get; set; }



    }
}
