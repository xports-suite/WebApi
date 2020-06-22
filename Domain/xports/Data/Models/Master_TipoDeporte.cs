using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Master_TipoDeporte
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public string Descripcion { get; set; }
        public int? Min_Jugadores { get; set; }
        public int? Max_Jugadores { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool? Activo { get; set; }
    }
}
