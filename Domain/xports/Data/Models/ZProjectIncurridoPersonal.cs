using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectIncurridoPersonal
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidPresupuestopersonal { get; set; }
        public Guid UidPerson { get; set; }
        public double? ImporteT1 { get; set; }
        public double? ImporteT2 { get; set; }
        public double? ImporteT3 { get; set; }
        public double? ImporteT4 { get; set; }
        public decimal? HorasT1 { get; set; }
        public decimal? HorasT2 { get; set; }
        public decimal? HorasT3 { get; set; }
        public decimal? HorasT4 { get; set; }
        public double? CosteT1 { get; set; }
        public double? CosteT2 { get; set; }
        public double? CosteT3 { get; set; }
        public double? CosteT4 { get; set; }
        public decimal? Estado { get; set; }
        public double? ImporteTotal { get; set; }
        public decimal? HorasTotal { get; set; }
        public Guid UidPtoAsig { get; set; }

        public virtual ZProjectPresupuesto UidPresupuestopersonalNavigation { get; set; }
    }
}
