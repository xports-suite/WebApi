using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Equipos_Jugadores
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Equipo { get; set; }
        public Guid UID_Person { get; set; }
        public string Apodo { get; set; }
        public int? Dorsal { get; set; }
        public bool? Portero { get; set; }
        public string Observaciones { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}
