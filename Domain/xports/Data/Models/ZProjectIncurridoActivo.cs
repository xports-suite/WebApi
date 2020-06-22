using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectIncurridoActivo
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidPresupuestoactivo { get; set; }
        public double Porcentaje { get; set; }
        public double NumMeses { get; set; }
        public double Importe { get; set; }
        public int Estado { get; set; }

        public virtual ZProjectPresupuestoActivo UidPresupuestoactivoNavigation { get; set; }
    }
}
