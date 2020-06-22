using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Instalaciones_Reserva_Lin
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Reserva { get; set; }
        public Guid? UID_Person { get; set; }
        public Guid? UID_Personal_Club { get; set; }
        public Guid? UID_Recibo { get; set; }
        public bool Pagado { get; set; }
        public int Orden { get; set; }
        public int? Unidades { get; set; }
    }
}
