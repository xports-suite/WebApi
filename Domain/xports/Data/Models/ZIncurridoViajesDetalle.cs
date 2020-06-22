using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZIncurridoViajesDetalle
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidIncurridoviaje { get; set; }
        public Guid UidPerson { get; set; }
        public int TipoJustificante { get; set; }
        public string NumJustificante { get; set; }
        public string RefHojaLiq { get; set; }
        public DateTime? FechaPago { get; set; }
        public double Base { get; set; }
        public double ImporteIva { get; set; }
        public double Imputado { get; set; }
        public int Estado { get; set; }

        public virtual ZProjectIncurridoViajes UidIncurridoviajeNavigation { get; set; }
    }
}
