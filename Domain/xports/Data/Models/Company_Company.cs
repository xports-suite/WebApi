using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Company
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public string CIF { get; set; }
        public string Nombre { get; set; }
        public string Acronimo { get; set; }
        public Guid UID_TipoEmpresa { get; set; }
        public Guid UID_Area { get; set; }
        public Guid UID_Country { get; set; }
        public int? Num_Usuarios_Fact { get; set; }
        public int? Num_Empleados { get; set; }
        public int? Horas_Convenio { get; set; }
        public string Menu { get; set; }
        public string File_Logo { get; set; }
        public string File_Css { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool Activo { get; set; }
    }
}
