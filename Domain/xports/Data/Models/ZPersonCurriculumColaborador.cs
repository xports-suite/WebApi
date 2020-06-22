using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZPersonCurriculumColaborador
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidPerson { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Puesto { get; set; }
        public string Company { get; set; }
        public string Comments { get; set; }
        public byte[] Ts { get; set; }

        public virtual ZPersonPersonColaborador UidPersonNavigation { get; set; }
    }
}
