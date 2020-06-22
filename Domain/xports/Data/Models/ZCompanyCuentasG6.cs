using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZCompanyCuentasG6
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidCompany { get; set; }
        public decimal Ejercicio { get; set; }
        public string Cuenta { get; set; }
        public string Concepto { get; set; }
        public double Valor { get; set; }
    }
}
