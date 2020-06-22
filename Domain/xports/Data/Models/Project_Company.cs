using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Project_Company
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_PROJECT { get; set; }
        public Guid UID_COMPANY { get; set; }
        public string Lider { get; set; }
    }
}
