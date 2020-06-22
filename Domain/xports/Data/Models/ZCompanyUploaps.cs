using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZCompanyUploaps
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidProject { get; set; }
        public Guid UidCompany { get; set; }
        public Guid UidPartida { get; set; }
        public int Ejercicio { get; set; }
        public string Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public Guid UidUsuario { get; set; }
    }
}
