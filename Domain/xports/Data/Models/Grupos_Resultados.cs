using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Grupos_Resultados
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Grupo { get; set; }
        public int Jornada { get; set; }
        public int Orden { get; set; }
        public Guid? UID_Equipo_L { get; set; }
        public Guid? UID_Equipo_V { get; set; }
        public int? Marcador_L { get; set; }
        public int? Marcador_V { get; set; }
        public int? Set_1_L { get; set; }
        public int? Set_1_V { get; set; }
        public int? Set_1_Ptos_L { get; set; }
        public int? Set_1_Ptos_V { get; set; }
        public int? Set_2_L { get; set; }
        public int? Set_2_V { get; set; }
        public int? Set_2_Ptos_L { get; set; }
        public int? Set_2_Ptos_V { get; set; }
        public int? Set_3_L { get; set; }
        public int? Set_3_V { get; set; }
        public int? Set_3_Ptos_L { get; set; }
        public int? Set_3_Ptos_V { get; set; }
        public Guid? UID_RESERVA { get; set; }
        public Guid? UID_ARBITRO { get; set; }
        public Guid? UID_USER_RESULTADO { get; set; }
        public bool? Partido_Reportado { get; set; }
        public DateTime? Fecha_Resultado { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
