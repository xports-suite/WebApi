using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class SecurityEventLog
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public Guid? UidCompany { get; set; }
        public Guid UidUser { get; set; }
        public Guid? UidPrograma { get; set; }
        public Guid? UidRegistro { get; set; }
        public string Ipclient { get; set; }
        public string Descripcion { get; set; }
        public string Tabla { get; set; }
        public string Evento { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
