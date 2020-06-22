using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectPtoFinanciable
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidProjectcompany { get; set; }
        public Guid UidFaseejercicio { get; set; }
        public Guid UidPartidapresupuestaria { get; set; }
        public decimal? Importe { get; set; }
    }
}
