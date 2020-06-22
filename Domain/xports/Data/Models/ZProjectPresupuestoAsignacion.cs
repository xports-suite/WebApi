using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectPresupuestoAsignacion
    {
        public ZProjectPresupuestoAsignacion()
        {
            ZProjectPresupuestoActivo = new HashSet<ZProjectPresupuestoActivo>();
            ZProjectPresupuestoColaborador = new HashSet<ZProjectPresupuestoColaborador>();
            ZProjectPresupuestoFungible = new HashSet<ZProjectPresupuestoFungible>();
        }

        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidProjectcompany { get; set; }
        public Guid UidPartida { get; set; }
        public Guid UidRecurso { get; set; }

        public virtual ICollection<ZProjectPresupuestoActivo> ZProjectPresupuestoActivo { get; set; }
        public virtual ICollection<ZProjectPresupuestoColaborador> ZProjectPresupuestoColaborador { get; set; }
        public virtual ICollection<ZProjectPresupuestoFungible> ZProjectPresupuestoFungible { get; set; }
    }
}
