using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class GruposResultados
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidGrupo { get; set; }
        public int Jornada { get; set; }
        public int Orden { get; set; }
        public Guid? UidEquipoL { get; set; }
        public Guid? UidEquipoV { get; set; }
        public int? MarcadorL { get; set; }
        public int? MarcadorV { get; set; }
        public int? Set1L { get; set; }
        public int? Set1V { get; set; }
        public int? Set1PtosL { get; set; }
        public int? Set1PtosV { get; set; }
        public int? Set2L { get; set; }
        public int? Set2V { get; set; }
        public int? Set2PtosL { get; set; }
        public int? Set2PtosV { get; set; }
        public int? Set3L { get; set; }
        public int? Set3V { get; set; }
        public int? Set3PtosL { get; set; }
        public int? Set3PtosV { get; set; }
        public Guid? UidReserva { get; set; }
        public Guid? UidArbitro { get; set; }
        public Guid? UidUserResultado { get; set; }
        public bool? PartidoReportado { get; set; }
        public DateTime? FechaResultado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
