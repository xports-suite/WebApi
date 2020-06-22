using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Grupos_Clasificaciones
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Grupo { get; set; }
        public Guid UID_Equipo { get; set; }
        public int Posicion { get; set; }
        public int Partidos_Jugados { get; set; }
        public int Puntos { get; set; }
        public int A_favor { get; set; }
        public int En_contra { get; set; }
        public int P_Ganados_C { get; set; }
        public int P_Perdidos_C { get; set; }
        public int P_Empatados_C { get; set; }
        public int P_Ganados_F { get; set; }
        public int P_Perdidos_F { get; set; }
        public int P_Empatados_F { get; set; }
        public int Puntos_C { get; set; }
        public int a_Favor_C { get; set; }
        public int en_Contra_C { get; set; }
        public int Puntos_F { get; set; }
        public int a_Favor_F { get; set; }
        public int en_Contra_F { get; set; }
        public int Jornada { get; set; }
        public DateTime Fecha_Actualizacion { get; set; }
    }
}
