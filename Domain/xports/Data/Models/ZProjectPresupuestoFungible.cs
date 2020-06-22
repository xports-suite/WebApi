using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectPresupuestoFungible
    {
        public ZProjectPresupuestoFungible()
        {
            ZProjectIncurridoFungible = new HashSet<ZProjectIncurridoFungible>();
        }

        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidFamilia { get; set; }
        public Guid UidPresupuesto { get; set; }
        public double Importe { get; set; }
        public Guid UidPtoAsig { get; set; }

        public virtual ZFungibleFamilia UidFamiliaNavigation { get; set; }
        public virtual ZProjectPresupuesto UidPresupuestoNavigation { get; set; }
        public virtual ZProjectPresupuestoAsignacion UidPtoAsigNavigation { get; set; }
        public virtual ICollection<ZProjectIncurridoFungible> ZProjectIncurridoFungible { get; set; }
    }
}
