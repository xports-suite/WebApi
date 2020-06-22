using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Fase_Equipos
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_ProjectFase { get; set; }
        public string Nombre { get; set; }
        public Guid UID_Person1 { get; set; }
        public Guid? UID_Person2 { get; set; }
        public string Color_1e { get; set; }
        public string Color_2e { get; set; }
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
        public bool Activo { get; set; }
        public string Observaciones { get; set; }
        public int Num_Jugadores { get; set; }
        public int Orden { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public Guid? UID_Tarifa { get; set; }
    }
}
