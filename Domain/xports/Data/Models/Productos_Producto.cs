using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Productos_Producto
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Familia { get; set; }
        public Guid UID_Proveedor { get; set; }
        public string Referencia { get; set; }
        public string Descripcion { get; set; }
        public double Importe_Neto { get; set; }
        public Guid UID_TipoImpuesto { get; set; }
        public double Importe_Venta { get; set; }
        public DateTime Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool Activo { get; set; }
    }
}
