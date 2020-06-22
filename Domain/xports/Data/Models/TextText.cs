using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class TextText
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public DateTime Fecha { get; set; }
        public string Texto { get; set; }
        public Guid? UidUser { get; set; }
        public byte[] Ts { get; set; }
    }
}
