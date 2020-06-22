using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Project_Users
    {
        public decimal id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_PROJECTCOMPANY { get; set; }
        public Guid UID_USER { get; set; }
        public Guid UID_PERFIL { get; set; }
    }
}
