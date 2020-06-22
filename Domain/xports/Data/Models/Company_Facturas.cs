using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Facturas
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_Company { get; set; }
        public Guid? UID_Numerador { get; set; }
        public Guid? UID_TipoImpuesto { get; set; }
        public Guid? UID_Person { get; set; }
        public string Numerador { get; set; }
        public string Cif { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public double? Base_Imponible { get; set; }
        public double? TotalDto { get; set; }
        public string Importe_Impuesto { get; set; }
        public double? Importe_Total { get; set; }
        public bool? Abono { get; set; }
        public DateTime? Fecha_Factura { get; set; }
        public DateTime? Fecha_Alta { get; set; }
    }
}
