using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Master_Procedimientos
    {
        public string vc_Procedimiento { get; set; }
        public string vc_Descripcion { get; set; }
        public int int_Version { get; set; }
        public DateTime dt_Fecha_revision { get; set; }
        public string vc_Comentario { get; set; }
    }
}
