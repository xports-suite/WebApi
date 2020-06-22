using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Security_EventLog
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_COMPANY { get; set; }
        public Guid UID_USER { get; set; }
        public Guid? UID_PROGRAMA { get; set; }
        public Guid? UID_REGISTRO { get; set; }
        public string IPClient { get; set; }
        public string Descripcion { get; set; }
        public string Tabla { get; set; }
        public string Evento { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
