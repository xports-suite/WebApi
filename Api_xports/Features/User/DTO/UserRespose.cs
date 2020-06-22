using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.User.DTO
{
    ///
    public class UserRespose
    {
        ///
        public Guid Id { get; set; }
        ///
        public string AppUserId { get; set; }
        ///
        public string Nombre { get; set; }
        ///
        public string Apellidos { get; set; }
        ///
        public string email { get; set; }
        ///
        public bool bloqueado { get; set; }
    }
}
