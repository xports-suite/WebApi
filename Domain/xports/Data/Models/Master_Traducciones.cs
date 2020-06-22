using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Master_Traducciones
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public string Code { get; set; }
        public string ES { get; set; }
        public string ENG { get; set; }
    }
}
