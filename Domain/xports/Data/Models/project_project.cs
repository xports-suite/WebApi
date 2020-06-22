using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class project_project
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid? UID_COMPANY { get; set; }
        public string Titulo { get; set; }
        public string Acronimo { get; set; }
        public string DescripcionCorta { get; set; }
        public Guid? UID_DESCRIPCIONLARGA { get; set; }
        public Guid? UID_DIRECTOR { get; set; }
        public Guid? UID_Deporte { get; set; }
        public Guid? UID_TipoDeporte { get; set; }
        public Guid? UID_NivelDeporte { get; set; }
        public Guid? UID_ProjectType { get; set; }
        public Guid? UID_ClaseActividad { get; set; }
        public DateTime? Fecha_Inicio_Plan { get; set; }
        public DateTime? Fecha_Fin_Plan { get; set; }
        public DateTime? Fecha_Inicio_Plan_FT { get; set; }
        public DateTime? Fecha_Fin_Plan_FT { get; set; }
        public DateTime? Fecha_Inicio_Real { get; set; }
        public DateTime? Fecha_Fin_Real { get; set; }
        public bool? EsProyecto { get; set; }
        public int? Status { get; set; }
        public string File_Logo { get; set; }
        public int? Num_Inscritos { get; set; }
        public bool? Requiere_Inscripcion { get; set; }
        public bool? Arbitro { get; set; }
        public int? Mangas { get; set; }
        public bool? Goleadores { get; set; }
        public int? Puntuacion_G { get; set; }
        public int? Puntuacion_E { get; set; }
        public int? Puntuacion_P { get; set; }
        public bool? Tarjetas { get; set; }
        public int? Sancion_Partidos { get; set; }
        public int? Sancion_Economica { get; set; }
        public bool? Resultados { get; set; }
        public int? Num_Equipos_Grupo { get; set; }
    }
}
