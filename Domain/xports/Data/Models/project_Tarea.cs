using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class project_Tarea
    {
        public decimal id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_FASE { get; set; }
        public string Nombre { get; set; }
        public Guid? UID_DESCRIPCION { get; set; }
        public Guid? UID_OBJETIVOS { get; set; }
        public decimal? Secuencia { get; set; }
        public DateTime? Fecha_Inicio_Plan { get; set; }
        public DateTime? Fecha_Fin_Plan { get; set; }
        public DateTime? Fecha_Inicio_Real { get; set; }
        public DateTime? Fecha_Fin_Real { get; set; }
        public Guid? UID_COMENTARIOS { get; set; }
        public byte[] ts { get; set; }
    }
}
