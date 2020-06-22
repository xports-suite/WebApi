using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZPersonEco
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid? UidPerson { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public double? SalarioAnualEstimado { get; set; }
        public double? SsAnualEstimado { get; set; }
        public double? SalarioAnualReal { get; set; }
        public double? SsAnualReal { get; set; }
        public double? HorasAnualEstimado { get; set; }
        public double? HorasAnualReal { get; set; }
        public double? CosteAnualEstimado { get; set; }
        public double? CosteAnualReal { get; set; }
        public byte[] Ts { get; set; }
        public bool? Alta { get; set; }
        public bool? Baja { get; set; }
        public decimal? HorasMaxT1 { get; set; }
        public decimal? HorasMaxT2 { get; set; }
        public decimal? HorasMaxT3 { get; set; }
        public decimal? HorasMaxT4 { get; set; }
        public double? CoeficienteAplic { get; set; }
        public double? Contingencias { get; set; }
        public double? Bonificaciones { get; set; }
    }
}
