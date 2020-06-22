using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Deporte_Tiempo
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Deporte { get; set; }
        public Guid UID_Tiempo { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime Fechahasta { get; set; }
        public decimal Importe_Equipo { get; set; }
        public decimal Importe_Usuario { get; set; }
        public Guid UID_TipoReserva { get; set; }
    }
}
