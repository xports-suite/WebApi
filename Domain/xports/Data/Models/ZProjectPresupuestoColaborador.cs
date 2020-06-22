using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectPresupuestoColaborador
    {
        public ZProjectPresupuestoColaborador()
        {
            ZProjectIncurridoColaborador = new HashSet<ZProjectIncurridoColaborador>();
        }

        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidTipocolaborador { get; set; }
        public Guid UidColaborador { get; set; }
        public Guid UidPresupuesto { get; set; }
        public double? Importe { get; set; }
        public Guid UidPtoAsig { get; set; }

        public virtual ZColaboradorColaborador UidColaboradorNavigation { get; set; }
        public virtual ZProjectPresupuesto UidPresupuestoNavigation { get; set; }
        public virtual ZProjectPresupuestoAsignacion UidPtoAsigNavigation { get; set; }
        public virtual ICollection<ZProjectIncurridoColaborador> ZProjectIncurridoColaborador { get; set; }
    }
}
