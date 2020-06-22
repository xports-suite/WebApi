using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Tarifas
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Company { get; set; }
        public Guid UID_ProjectType { get; set; }
        public Guid? UID_Deporte { get; set; }
        public string Descripcion { get; set; }
        public double? Importe { get; set; }
        public int? Num_Minutos { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool Activo { get; set; }
    }
}
