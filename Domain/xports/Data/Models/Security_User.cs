using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Security_User
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public string Username { get; set; }
        public Guid UID_PERSON { get; set; }
        public Guid UID_COMPANY { get; set; }
        public Guid? UID_PROFILE { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool? Activo { get; set; }
    }
}
