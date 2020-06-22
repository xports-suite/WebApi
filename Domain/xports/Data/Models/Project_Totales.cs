using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Project_Totales
    {
        public decimal id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_PROJECTCOMPANY { get; set; }
        public Guid UID_PARTIDAPRESUPUESTARIA { get; set; }
        public int Ejercicio { get; set; }
        public decimal? Importe_Pto { get; set; }
        public decimal? Importe_Incurrido { get; set; }
        public decimal? Importe_Estado1 { get; set; }
        public decimal? Importe_Estado2 { get; set; }
        public decimal? Importe_Estado3 { get; set; }
        public decimal? Importe_Estado4 { get; set; }
        public int? Horas_Pto { get; set; }
        public int? Horas_Incurrido { get; set; }
        public decimal? Importe_Admin_Pto { get; set; }
        public decimal? Importe_Admin_Incurrido { get; set; }
        public decimal? Importe_Otras_Pto { get; set; }
        public decimal? Importe_Otras_Incurrido { get; set; }
        public double? Porcentaje_Total_Pto { get; set; }
        public double? Porcentaje_Total_Incurrido { get; set; }
        public int? Estipo { get; set; }
        public decimal? Importe_Admin_Estado1 { get; set; }
        public decimal? Importe_Admin_Estado2 { get; set; }
        public decimal? Importe_Admin_Estado3 { get; set; }
        public decimal? Importe_Admin_Estado4 { get; set; }
        public decimal? Importe_Otras_Estado1 { get; set; }
        public decimal? Importe_Otras_Estado2 { get; set; }
        public decimal? Importe_Otras_Estado3 { get; set; }
        public decimal? Importe_Otras_Estado4 { get; set; }
    }
}
