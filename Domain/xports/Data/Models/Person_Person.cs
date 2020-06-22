using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class Person_Person
    {
        public int id { get; set; }
        public Guid UID { get; set; }
        public Guid UID_COMPANY { get; set; }
        public Guid? UID_TIPOPERSONAL { get; set; }
        public Guid? UID_DELEGACION { get; set; }
        public string Code { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string CodigoPostal { get; set; }
        public string Foto { get; set; }
        public string Sexo { get; set; }
        public string DNI { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Talla { get; set; }
        public string Titulacion { get; set; }
        public string Num_Cuenta { get; set; }
        public bool? DomiciliarRecibos { get; set; }
        public string Observaciones { get; set; }
        public Guid? UID_UNIDAD_FAMILIAR { get; set; }
        public Guid? UID_TipoDescuento { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public DateTime? Fecha_Baja { get; set; }
        public bool? Activo { get; set; }
    }
}
