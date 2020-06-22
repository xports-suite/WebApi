using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Instalaciones_Cab
    {
        public decimal id { get; set; }
        public Guid UID_Company { get; set; }
        public Guid UID { get; set; }
        public string Nombre { get; set; }
        public string P_Contacto { get; set; }
        public string T_Contacto { get; set; }
        public string M_Contacto { get; set; }
        public string H_Contacto { get; set; }
        public string url_Contacto { get; set; }
        public string Observaciones { get; set; }
        public bool Ins_Propias { get; set; }
        public bool Activo { get; set; }
    }
}
