using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_TipoPersonal
    {
        public decimal id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_PROJECTCOMPANY { get; set; }
        public Guid UID_TIPOPERSONAL { get; set; }
        public int? Ejercicio { get; set; }
        public double? Importe { get; set; }
    }
}
