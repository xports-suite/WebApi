using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Facturas_Lin
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_Factura { get; set; }
        public Guid? UID_Recibo { get; set; }
    }
}
