using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ConfigParameter
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public Guid? UidCompany { get; set; }
        public string Finalidad { get; set; }
        public string Parameter { get; set; }
        public string Valor { get; set; }
    }
}
