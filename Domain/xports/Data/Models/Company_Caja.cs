using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Caja
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_Company { get; set; }
        public DateTime? Fecha { get; set; }
        public double? Importe_Apertura { get; set; }
        public double? Importe_Metalico { get; set; }
        public double? Importe_Tarjeta { get; set; }
        public double? Importe_Retirado { get; set; }
        public double? Importe_Cierre { get; set; }
        public double? Importe_Ingresos { get; set; }
        public double? Importe_Pagos { get; set; }
        public double? Importe_Descuadre { get; set; }
        public double? Importe_Caja { get; set; }
    }
}
