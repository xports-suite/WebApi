using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectPresupuestoPersonal
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidTipopersonal { get; set; }
        public Guid UidPresupuesto { get; set; }
        public decimal? NumHoras { get; set; }
        public decimal? NumPersonas { get; set; }
        public double? Importe { get; set; }

        public virtual ZProjectPresupuesto UidPresupuestoNavigation { get; set; }
    }
}
