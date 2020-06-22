using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZProjectFaseEjercicio
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidFase { get; set; }
        public int Ejercicio { get; set; }
        public bool? Estado { get; set; }
    }
}
