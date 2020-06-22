using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZPersonPersonColaborador
    {
        public ZPersonPersonColaborador()
        {
            ZPersonCurriculumColaborador = new HashSet<ZPersonCurriculumColaborador>();
            ZPersonEcoColaborador = new HashSet<ZPersonEcoColaborador>();
        }

        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid UidCompany { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Telephone2 { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public Guid? UidComentarios { get; set; }
        public byte[] Ts { get; set; }
        public string Cargo { get; set; }
        public string Sexo { get; set; }
        public string Dni { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Departamento { get; set; }

        public virtual ZColaboradorColaborador UidCompanyNavigation { get; set; }
        public virtual ICollection<ZPersonCurriculumColaborador> ZPersonCurriculumColaborador { get; set; }
        public virtual ICollection<ZPersonEcoColaborador> ZPersonEcoColaborador { get; set; }
    }
}
