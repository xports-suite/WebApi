using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.User.DTO
{
    ///
    public class UserSetRequest
    {
        ///
        public Guid Id { get; set; }
        ///
        public string UserLogin { get; set; }
        ///
        public string Nombre { get; set; }
        ///
        public string Apellidos { get; set; }
        ///
        public string Email { get; set; }
        ///
        public bool Bloqueado { get; set; }
    }
}
