using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Numeradores
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_COMPANY { get; set; }
        public int? Ejercicio { get; set; }
        public string Serie { get; set; }
        public int? Numero { get; set; }
        public int? TipoAbonoCargo { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool Activo { get; set; }
    }
}
