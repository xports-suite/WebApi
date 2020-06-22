using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Company_Instalaciones_Detalle
    {
        public decimal id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_Instalaciones_Cab { get; set; }
        public Guid UID_Deporte { get; set; }
        public int Num_Instalacion { get; set; }
        public string Nombre { get; set; }
        public int Hora_Comienzo { get; set; }
        public int Minuto_Comienzo { get; set; }
        public string Dias_Disponibilidad { get; set; }
        public int Hora_Fin { get; set; }
        public int Minuto_Fin { get; set; }
        public int Intervalos_Minutos { get; set; }
        public bool Activo { get; set; }
        public string Disponible_HREF { get; set; }
        public string Cerrado_HREF { get; set; }
        public string Reservado_HREF { get; set; }
        public string Pendiente_Pago_HREF { get; set; }
        public string Abonado_HREF { get; set; }
    }
}
