using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectPersonalAsignado
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidProjectcompany { get; set; }
        public Guid UidPersonal { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FAlta { get; set; }
        public DateTime? FBaja { get; set; }
        public Guid? UsuValidacion { get; set; }
        public DateTime? FValidación { get; set; }
        public bool? DiaJuegoL { get; set; }
        public bool? DiaJuegoM { get; set; }
        public bool? DiaJuegoX { get; set; }
        public bool? DiaJuegoJ { get; set; }
        public bool? DiaJuegoV { get; set; }
        public bool? DiaJuegoS { get; set; }
        public bool? DiaJuegoD { get; set; }
        public bool? DiaJuegoT { get; set; }
    }
}
