using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Fase_Grupos
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_ProjectFase { get; set; }
        public int Orden { get; set; }
        public string Nombre { get; set; }
        public int Num_Grupo { get; set; }
        public int Num_Equipos { get; set; }
        public string Observaciones { get; set; }
    }
}
