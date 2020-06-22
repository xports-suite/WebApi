using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Cuenta.DTO
{
    ///
    public class UserLogin_Dto
    {
        ///
        [Required]
        public string Login { get; set; }
        ///
        [Required]
        public string Password { get; set; }
    }
}
