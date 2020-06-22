using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DTO
{
    public class ReservaFilterRepositoryDto
    {
        
        public Guid uid_company { get; set; }
        public DateTime fecha { get; set; }
        public Guid uid_deporte { get; set; }
    }
}
