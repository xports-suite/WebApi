using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Master_Jerarquia_Menus
    {
        public int id { get; set; }
        public Guid UID_FUNCTION { get; set; }
        public Guid UID_PERFIL { get; set; }
        public string Perfil { get; set; }
        public string Menu { get; set; }
        public string Jerarquia { get; set; }
        public int? Nivel { get; set; }
        public Guid? UID_Padre { get; set; }
        public string Orden { get; set; }
        public int? Posicion { get; set; }
        public string Url { get; set; }
        public string Icono { get; set; }
    }
}
