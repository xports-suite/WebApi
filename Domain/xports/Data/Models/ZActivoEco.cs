using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZActivoEco
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidActivo { get; set; }
        public decimal Ejercicio { get; set; }
        public decimal Importe { get; set; }
        public decimal Meses { get; set; }
        public decimal ImporteMes { get; set; }
        public decimal? ImportePre { get; set; }
        public decimal? MesesPre { get; set; }
        public decimal? ImporteMesPre { get; set; }
        public decimal ImportePto { get; set; }
        public decimal MesesPto { get; set; }
        public decimal ImporteMesPto { get; set; }
        public decimal Estado { get; set; }

        public virtual ZActivoActivo UidActivoNavigation { get; set; }
    }
}
