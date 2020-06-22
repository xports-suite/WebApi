using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Presupuesto
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public int Ejercicio { get; set; }
        public double? Presupuesto { get; set; }
        public double? Incurrido { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
