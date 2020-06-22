using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Caja_Movimientos_Lin
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Movimiento { get; set; }
        public Guid UID_Recibo { get; set; }
    }
}
