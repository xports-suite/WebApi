using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectIncurridoColaborador
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidPresupuestocolaborador { get; set; }
        public decimal Estado { get; set; }
        public double Importe { get; set; }
        public string Factura { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public double? ImporteIva { get; set; }
        public DateTime? FechaPago { get; set; }

        public virtual ZProjectPresupuestoColaborador UidPresupuestocolaboradorNavigation { get; set; }
    }
}
