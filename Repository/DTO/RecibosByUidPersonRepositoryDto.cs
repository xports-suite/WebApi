using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DTO
{
   public  class RecibosByUidPersonRepositoryDto
    {
        public Guid uidRecibo { get; set; }

        public Guid uidReserva { get; set; }

        public Guid? uidProjectFase { get; set; }

        public Guid? uidProducto { get; set; }

        public string descripcion { get; set; }

        public double importeUnitario { get; set; }

        public int unidades { get; set; }

        public double importeTotal { get; set; }

        public string estadoRecibo { get; set; }

        public DateTime fechaRecibo { get; set; }
        public double totalRecibo { get; set; }
        public double importePagado { get; set; }
        public double importePendiente { get; set; }

    }
}
