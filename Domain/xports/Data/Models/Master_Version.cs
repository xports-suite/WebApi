using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Master_Version
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public string Descripcion { get; set; }
        public decimal? Version { get; set; }
        public DateTime FechaVersion { get; set; }
    }
}
