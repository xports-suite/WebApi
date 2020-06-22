using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectIncurrido
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidProjectcompany { get; set; }
        public Guid UidPartidapresupuestaria { get; set; }
        public Guid UidFaseejercicio { get; set; }
        public decimal? ImportePto { get; set; }
        public decimal? ImporteIncurrido { get; set; }
        public decimal? ImporteEstado1 { get; set; }
        public decimal? ImporteEstado2 { get; set; }
        public decimal? ImporteEstado3 { get; set; }
        public decimal? ImporteEstado4 { get; set; }
        public int? HorasPto { get; set; }
        public int? HorasIncurrido { get; set; }
        public decimal? ImporteAdminPto { get; set; }
        public decimal? ImporteAdminIncurrido { get; set; }
        public decimal? ImporteOtrasPto { get; set; }
        public decimal? ImporteOtrasIncurrido { get; set; }
        public int? Estipo { get; set; }
        public decimal? ImporteAdminEstado1 { get; set; }
        public decimal? ImporteAdminEstado2 { get; set; }
        public decimal? ImporteAdminEstado3 { get; set; }
        public decimal? ImporteAdminEstado4 { get; set; }
        public decimal? ImporteOtrasEstado1 { get; set; }
        public decimal? ImporteOtrasEstado2 { get; set; }
        public decimal? ImporteOtrasEstado3 { get; set; }
        public decimal? ImporteOtrasEstado4 { get; set; }
    }
}
