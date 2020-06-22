using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Reservas.DTO.Response
{
    /// <summary>
    /// Clase que representa las instalaciones
    /// </summary>
    public class EventosResponse
    {
        /// <summary>
        /// Objecto instalaciones 
        /// </summary>
        public EventosResponse()
        {
            Instalaciones = new List<InstalacionResponse>();
            Eventos = new List<EventoResponse>();
        }
        /// <summary>
        /// Instalaciones
        /// </summary>
        public List<InstalacionResponse> Instalaciones { get; set; }

        /// <summary>
        /// Eventos
        /// </summary>
        public List<EventoResponse> Eventos { get; set; }

    }
    /// <summary>
    /// 
    /// </summary>
    public class InstalacionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }

         /// <summary>
        /// Color de la instalacion
        /// </summary>
        public string color { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class EventoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string uid_reserva { get; set; }
        /// <summary>
        /// Titulo
        /// </summary>
        /// public string title { get; set; }
        
        /// <summary>
        /// Fecha Comienzo
        /// </summary>
        public DateTime start { get; set; }
        /// <summary>
        /// Identiicador de la instalacion
        /// </summary>
        public int idinstalacion { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string uid_instalacion { get; set; }

        /// <summary>
        /// Fecha Fin
        /// </summary>
        public DateTime end { get; set; }

        /// <summary>
        /// Identificador de la persona
        /// </summary>
        public string uid_person { get; set; }

        /// <summary>
        /// Nombre Reserva
        /// </summary>
        public string nombreReserva { get; set; }
        ///
        public string colorReserva { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string uid_tipoReserva { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<GroupUsers> uidGroupUsers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// public List<int> idPaymentPartsUsers { get; set; }



    }

    /// <summary>
    /// 
    /// </summary>
    public class GroupUsers
    {
        /// <summary>
        /// 
        /// </summary>
        public int orden { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid uidPerson { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int unidades { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nombre { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int StatusBill { get; set; }
    }
}
