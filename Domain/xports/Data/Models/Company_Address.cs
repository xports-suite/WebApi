using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Address
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Company { get; set; }
        public Guid UID_AddressType { get; set; }
        public Guid UID_Country { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string CodigoPostal { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool? Activo { get; set; }
    }
}
