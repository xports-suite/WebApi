using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZCompanyCostesIndirectos
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidProjectcompany { get; set; }
        public decimal Ejercicio { get; set; }
        public double? ImportePto { get; set; }
        public double? PorcentajeIncu { get; set; }
        public double? ImporteIncu { get; set; }
    }
}
