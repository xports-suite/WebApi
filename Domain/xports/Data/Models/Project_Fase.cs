using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Project_Fase
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_PROJECT { get; set; }
        public Guid? UID_ESTADO { get; set; }
        public string Nombre { get; set; }
        public DateTime? Fecha_Inicio_Plan { get; set; }
        public DateTime? Fecha_Fin_Plan { get; set; }
        public DateTime? Fecha_Inicio_Real { get; set; }
        public DateTime? Fecha_Fin_Real { get; set; }
        public int? Secuencia { get; set; }
        public bool? Disponibilidad_L { get; set; }
        public string L_Desde_Hasta { get; set; }
        public bool? Disponibilidad_M { get; set; }
        public string M_Desde_Hasta { get; set; }
        public bool? Disponibilidad_X { get; set; }
        public string X_Desde_Hasta { get; set; }
        public bool? Disponibilidad_J { get; set; }
        public string J_Desde_Hasta { get; set; }
        public bool? Disponibilidad_V { get; set; }
        public string V_Desde_Hasta { get; set; }
        public bool? Disponibilidad_S { get; set; }
        public string S_Desde_Hasta { get; set; }
        public bool? Disponibilidad_D { get; set; }
        public string D_Desde_Hasta { get; set; }
        public int? Num_Minutos_Juego { get; set; }
        public int? Min_Dias_Entre_Jornadas { get; set; }
        public Guid? UID_Tarifa { get; set; }
    }
}
