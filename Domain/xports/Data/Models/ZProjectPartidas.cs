using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectPartidas
    {
        public ZProjectPartidas()
        {
            ZProjectPresupuesto = new HashSet<ZProjectPresupuesto>();
        }

        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidProject { get; set; }
        public Guid UidPartida { get; set; }

        public virtual ICollection<ZProjectPresupuesto> ZProjectPresupuesto { get; set; }
    }
}
