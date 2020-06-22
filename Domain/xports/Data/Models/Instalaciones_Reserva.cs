using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Instalaciones_Reserva
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Instalacion { get; set; }
        public DateTime FechaReserva { get; set; }
        public int id_hora { get; set; }
        public int Num_Minutos { get; set; }
        public Guid UID_Person_Reserva { get; set; }
        public Guid UID_TipoReserva { get; set; }
        public Guid? UID_Personal_Club { get; set; }
        public bool Pagado { get; set; }
        public bool Activo { get; set; }
        public string Observaciones { get; set; }
        public int Num_Usuarios { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public Guid UID_ProjectFase { get; set; }
    }
}
