using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Config_Parameter
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_COMPANY { get; set; }
        public string Finalidad { get; set; }
        public string Parameter { get; set; }
        public string Valor { get; set; }
    }
}
