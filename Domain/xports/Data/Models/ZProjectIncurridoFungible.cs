using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectIncurridoFungible
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public double Importe { get; set; }
        public decimal Estado { get; set; }
        public Guid UidPresupuestofungible { get; set; }
        public string Factura { get; set; }
        public DateTime? Fecha { get; set; }
        public string Proveedor { get; set; }
        public string Cif { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaPago { get; set; }
        public double ImporteIva { get; set; }

        public virtual ZProjectPresupuestoFungible UidPresupuestofungibleNavigation { get; set; }
    }
}
