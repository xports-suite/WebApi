using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class FungibleFungible
    {
        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid? UidCompany { get; set; }
        public Guid? UidFamilia { get; set; }
        public string Entidad { get; set; }
        public string Actividad { get; set; }
        public string Cif { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Provincia { get; set; }
        public Guid? Pais { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public byte[] Ts { get; set; }
    }
}
