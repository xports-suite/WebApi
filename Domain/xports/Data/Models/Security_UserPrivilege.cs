using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Security_UserPrivilege
    {
        public decimal id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_USER { get; set; }
        public Guid UID_FUNCTION { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool? Activo { get; set; }
    }
}
