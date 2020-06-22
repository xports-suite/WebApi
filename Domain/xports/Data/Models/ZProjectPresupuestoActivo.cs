using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectPresupuestoActivo
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidActivo { get; set; }
        public Guid UidPresupuesto { get; set; }
        public double? Porcentaje { get; set; }
        public double? NumMeses { get; set; }
        public double? Importe { get; set; }
        public Guid UidPtoAsig { get; set; }

        public virtual ZActivoActivo UidActivoNavigation { get; set; }
        public virtual ZProjectPresupuesto UidPresupuestoNavigation { get; set; }
        public virtual ZProjectPresupuestoAsignacion UidPtoAsigNavigation { get; set; }
        public virtual ZProjectIncurridoActivo ZProjectIncurridoActivo { get; set; }
    }
}
