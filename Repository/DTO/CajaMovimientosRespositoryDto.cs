using System;
namespace Repository.DTO
{
    public class CajaMovimientosRepositoryDto {
        public DateTime Fecha {get;set;}
        public Guid UID_Movimiento {get;set;}

        public string Tipo_Movimiento {get;set;}

        public string Forma_Pago {get;set;}

        public string Descripcion {get;set;}

        public double Importe {get;set;}
    }
}