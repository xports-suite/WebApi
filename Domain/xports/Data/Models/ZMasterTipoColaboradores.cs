using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZMasterTipoColaboradores
    {
        public ZMasterTipoColaboradores()
        {
            ZColaboradorColaborador = new HashSet<ZColaboradorColaborador>();
        }

        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] Ts { get; set; }
        public bool Admin { get; set; }

        public virtual ICollection<ZColaboradorColaborador> ZColaboradorColaborador { get; set; }
    }
}
