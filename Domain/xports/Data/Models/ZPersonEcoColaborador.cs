using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZPersonEcoColaborador
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid? UidPerson { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public double? SalarioAnualEstimado { get; set; }
        public double? SsAnualEstimado { get; set; }
        public double? SalarioAnualReal { get; set; }
        public double? SsAnualReal { get; set; }
        public double? HorasAnualEstimado { get; set; }
        public double? HorasAnualReal { get; set; }
        public double? CosteAnualEstimado { get; set; }
        public double? CosteAnualReal { get; set; }
        public byte[] Ts { get; set; }

        public virtual ZPersonPersonColaborador UidPersonNavigation { get; set; }
    }
}
