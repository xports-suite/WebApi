using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Master_LogErrores
    {
        public int id { get; set; }
        public string vc_Error_message { get; set; }
        public int? int_Error_line { get; set; }
        public string vc_Error_procedure { get; set; }
        public DateTime? dt_Error_date { get; set; }
        public string vc_Error_detail { get; set; }
    }
}
