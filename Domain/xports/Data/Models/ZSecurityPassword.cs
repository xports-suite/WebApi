using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZSecurityPassword
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidUser { get; set; }
        public string Password { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool? Activo { get; set; }
    }
}
