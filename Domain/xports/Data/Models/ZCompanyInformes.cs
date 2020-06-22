using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZCompanyInformes
    {
        public ZCompanyInformes()
        {
            ZSecurityReportPrivilege = new HashSet<ZSecurityReportPrivilege>();
        }

        public int Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidProjectCompany { get; set; }
        public string Informe { get; set; }
        public string Descripcion { get; set; }
        public string Plantilla { get; set; }
        public string CodigoOriginal { get; set; }
        public string Version { get; set; }
        public DateTime? FechaVersion { get; set; }
        public int? Orden { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<ZSecurityReportPrivilege> ZSecurityReportPrivilege { get; set; }
    }
}
