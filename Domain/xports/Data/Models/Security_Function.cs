using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Security_Function
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Guid? Raiz { get; set; }
        public int? Activo_Raiz { get; set; }
        public Guid? Padre { get; set; }
        public int? Posicion { get; set; }
        public string Icono { get; set; }
        public string Url { get; set; }
        public string Observaciones { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool? Activo { get; set; }
    }
}
