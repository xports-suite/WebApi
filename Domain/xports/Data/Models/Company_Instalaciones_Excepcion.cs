using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Instalaciones_Excepcion
    {
        public decimal id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Instalaciones_Cab { get; set; }
        public Guid? UID_Instalaciones_Det { get; set; }
        public Guid? UID_Deporte { get; set; }
        public string Descripcion { get; set; }
        public int Hora_Comienzo { get; set; }
        public int Minuto_Comienzo { get; set; }
        public string Dias_Excepcion { get; set; }
        public int Hora_Fin { get; set; }
        public int Minuto_Fin { get; set; }
        public DateTime? Fecha_Inicio { get; set; }
        public bool Activo { get; set; }
        public DateTime? Fecha_Fin { get; set; }
    }
}
