using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Recibos_Detalle
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_Recibo { get; set; }
        public Guid? UID_ProjectFase { get; set; }
        public Guid? UID_Reserva { get; set; }
        public Guid? UID_Producto { get; set; }
        public Guid? UID_TipoDescuento { get; set; }
        public string Descripcion { get; set; }
        public double? Importe_Unitario { get; set; }
        public int Unidades { get; set; }
        public double? Porcentaje_Dto { get; set; }
        public double? Importe_Dto { get; set; }
        public double Importe_Total { get; set; }
    }
}
