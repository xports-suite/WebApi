using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectIncurridoViajes
    {
        public ZProjectIncurridoViajes()
        {
            ZIncurridoViajesDetalle = new HashSet<ZIncurridoViajesDetalle>();
        }

        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidPresupuestoviaje { get; set; }
        public string Motivo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string RefSolicitud { get; set; }
        public double ImporteTotal { get; set; }

        public virtual ZProjectPresupuesto UidPresupuestoviajeNavigation { get; set; }
        public virtual ICollection<ZIncurridoViajesDetalle> ZIncurridoViajesDetalle { get; set; }
    }
}
