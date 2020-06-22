using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZSecurityReportPrivilege
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidProfile { get; set; }
        public Guid UidReport { get; set; }
        public bool? Allow { get; set; }
        public byte[] Ts { get; set; }
        public decimal Permisos { get; set; }
        public Guid UidProjectcompany { get; set; }

        public virtual ZCompanyInformes UidReportNavigation { get; set; }
    }
}
