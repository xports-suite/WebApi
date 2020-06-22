using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZActivoFamilia
    {
        public ZActivoFamilia()
        {
            ZActivoActivo = new HashSet<ZActivoActivo>();
        }

        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid? UidCompany { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] Ts { get; set; }

        public virtual ICollection<ZActivoActivo> ZActivoActivo { get; set; }
    }
}
