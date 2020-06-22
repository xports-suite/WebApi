using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Recibos.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class RecibosByCompany_Dto
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? uidRecibo { get; set; }

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
        public double? ImporteTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? ImportePagado { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? ImportePendiente { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid? uidFormaPago { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid? uidPerson { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid? uidEstadoRecibo { get; set; }
    }
}
