using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectPresupuesto
    {
        public ZProjectPresupuesto()
        {
            ZProjectIncurridoPersonal = new HashSet<ZProjectIncurridoPersonal>();
            ZProjectIncurridoViajes = new HashSet<ZProjectIncurridoViajes>();
            ZProjectPresupuestoActivo = new HashSet<ZProjectPresupuestoActivo>();
            ZProjectPresupuestoColaborador = new HashSet<ZProjectPresupuestoColaborador>();
            ZProjectPresupuestoFungible = new HashSet<ZProjectPresupuestoFungible>();
            ZProjectPresupuestoPersonal = new HashSet<ZProjectPresupuestoPersonal>();
        }

        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidProjectcompany { get; set; }
        public Guid UidFaseejercicio { get; set; }
        public Guid UidPartidapresupuestaria { get; set; }
        public string Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Importe { get; set; }
        public Guid? UidDescripcion { get; set; }

        public virtual ZProjectPartidas UidPartidapresupuestariaNavigation { get; set; }
        public virtual ICollection<ZProjectIncurridoPersonal> ZProjectIncurridoPersonal { get; set; }
        public virtual ICollection<ZProjectIncurridoViajes> ZProjectIncurridoViajes { get; set; }
        public virtual ICollection<ZProjectPresupuestoActivo> ZProjectPresupuestoActivo { get; set; }
        public virtual ICollection<ZProjectPresupuestoColaborador> ZProjectPresupuestoColaborador { get; set; }
        public virtual ICollection<ZProjectPresupuestoFungible> ZProjectPresupuestoFungible { get; set; }
        public virtual ICollection<ZProjectPresupuestoPersonal> ZProjectPresupuestoPersonal { get; set; }
    }
}
