using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Caja_Movimientos
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Caja { get; set; }
        public Guid UID_TipoMovimiento { get; set; }
        public Guid? UID_FormaPago { get; set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }
        public Guid UID_User { get; set; }
        public DateTime Fecha { get; set; }
    }
}
