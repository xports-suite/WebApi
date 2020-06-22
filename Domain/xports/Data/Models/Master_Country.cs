using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Master_Country
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public string Code { get; set; }
        public string Descripcion_es { get; set; }
        public string Descripcion_eng { get; set; }
        public string Continente { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool? Activo { get; set; }
    }
}
