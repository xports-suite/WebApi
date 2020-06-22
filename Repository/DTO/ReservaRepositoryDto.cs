using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DTO
{
   public class ReservaRepositoryDto
    {
        public Guid UID_Reserva { get; set; }
        public string Titulo { get; set; }
        public Guid UID_Instalacion { get; set; }
        public Guid UID_TipoReserva { get; set; }
        public DateTime dt_inicio { get; set; }
        public DateTime dt_fin { get; set; }
        public Guid UID_Person_Reserva { get; set; }

        public string uidGropusUser { get; set; }

        public string idPaymentPartsUsers { get; set; }

    }
}
