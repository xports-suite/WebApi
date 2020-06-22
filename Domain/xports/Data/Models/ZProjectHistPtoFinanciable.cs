using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectHistPtoFinanciable
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidProjectcompany { get; set; }
        public Guid UidFaseejercicio { get; set; }
        public Guid UidPartidapresupuestaria { get; set; }
        public DateTime FechaPto { get; set; }
        public string Nombre { get; set; }
        public decimal Importe { get; set; }
        public string Motivo { get; set; }
        public decimal SecuenciaHistorico { get; set; }
    }
}
