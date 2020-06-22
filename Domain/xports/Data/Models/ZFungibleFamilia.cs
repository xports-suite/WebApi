using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZFungibleFamilia
    {
        public ZFungibleFamilia()
        {
            ZProjectPresupuestoFungible = new HashSet<ZProjectPresupuestoFungible>();
        }

        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid? UidCompany { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] Ts { get; set; }

        public virtual ICollection<ZProjectPresupuestoFungible> ZProjectPresupuestoFungible { get; set; }
    }
}
