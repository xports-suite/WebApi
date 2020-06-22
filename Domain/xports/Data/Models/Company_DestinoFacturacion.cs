using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_DestinoFacturacion
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_COMPANY { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public Guid? UID_TIPOIMPUESTO { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool Activo { get; set; }
    }
}
