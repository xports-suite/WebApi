using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class GruposClasificaciones
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidGrupo { get; set; }
        public Guid UidEquipo { get; set; }
        public int Posicion { get; set; }
        public int PartidosJugados { get; set; }
        public int Puntos { get; set; }
        public int AFavor { get; set; }
        public int EnContra { get; set; }
        public int PGanadosC { get; set; }
        public int PPerdidosC { get; set; }
        public int PEmpatadosC { get; set; }
        public int PGanadosF { get; set; }
        public int PPerdidosF { get; set; }
        public int PEmpatadosF { get; set; }
        public int PuntosC { get; set; }
        public int AFavorC { get; set; }
        public int EnContraC { get; set; }
        public int PuntosF { get; set; }
        public int AFavorF { get; set; }
        public int EnContraF { get; set; }
        public int Jornada { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
