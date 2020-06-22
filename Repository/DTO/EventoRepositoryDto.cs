using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DTO
{
    public class EventoRepositoryDto
    {
        public Guid uid_instalacion { get; set; }

        public int num_instalacion { get; set; }

        public Guid uid_reserva { get; set; }

        // public string concepto { get; set; }

        public string detalle { get; set; }

        public int minutos { get; set; }

        public string Estado_Reserva { get; set; }

        public DateTime Fecha { get; set; }

        public string Hora_inicio { get; set; }

        public string Hora_fin { get; set; }

        public string color_reserva { get; set; }

        public Guid uid_Person { get; set; }

        public string Nombre_Reserva { get; set; }

        public Guid UID_Tipo_Reserva { get; set; }

        public string UID_Todos_Usuarios { get; set; }

        public string Todos_Unidades { get; set; }
    }
}
