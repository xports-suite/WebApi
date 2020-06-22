using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Recibos
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_Company { get; set; }
        public Guid UID_Person { get; set; }
        public Guid? UID_EstadoRecibo { get; set; }
        public Guid? UID_FormaPago { get; set; }
        public double? ImporteTotal { get; set; }
        public double? ImportePagado { get; set; }
        public double? ImportePendiente { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public DateTime? FechaPago { get; set; }
        public bool Activo { get; set; }
    }
}
