using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DTO
{
    public class LineaMovimientoRepositoryDto
    {
        public Guid uidcompany { get; set; }
        public Guid uidTipoMovimiento { get; set; }
        public Guid uidFormaPago { get; set; }
        public Guid uidUser { get; set; }
        public string uidRecibos { get; set; }
    }
}
