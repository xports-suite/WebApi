using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZMasterTipoActividad
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid? UidClaseactividad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] Ts { get; set; }
    }
}
