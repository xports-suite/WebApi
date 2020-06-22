using Api_xports.Features.Reservas.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Reservas.DTO.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class EventoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        /// 
        // public string Titulo { get; set; }
        ///
        public string uiReserva { get; set; }
        ///
        public List<GroupUsers> uidGroupUsers { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        // public List<int> idPaymentPartsUsers{ get; set; }
        ///
        public string start { get; set; }
        ///
        public string end { get; set; }
        ///
        public string uidInstalacion { get; set; }
        ///
        public string uidTipoReserva { get; set; }
        ///
        public string startTime { get; set; }
        ///
        public string endTime { get; set; }
    }
}
