using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZActivoFacturas
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidActivo { get; set; }
        public string Proveedor { get; set; }
        public string Cif { get; set; }
        public string Factura { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaPago { get; set; }
        public double? Importe { get; set; }
        public double? PorcentajeIva { get; set; }

        public virtual ZActivoActivo UidActivoNavigation { get; set; }
    }
}
