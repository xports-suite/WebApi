using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Security_Terminos
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_USER { get; set; }
        public string Username { get; set; }
        public DateTime Fecha_Alta { get; set; }
    }
}
