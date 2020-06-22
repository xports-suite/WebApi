using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class person_UnidadFamiliar
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_PERSON { get; set; }
        public bool? Principal { get; set; }
        public bool? Menor { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool? Activo { get; set; }
    }
}
