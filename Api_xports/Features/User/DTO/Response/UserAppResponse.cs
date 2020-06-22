using Api_xports.Features.Base.Validation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.User.DTO.Response
{
    /// <summary>
    /// Clase que representa un object de tipo usuario logado en la plataforma
    /// </summary>
    public class UserAppResponse : ValidationModel
    {
        /// <summary>
        /// Identificador de usuario logado
        /// </summary>
        public Guid uiPerson { get; set; }
        /// <summary>
        /// Identificador del rool del usuario logado
        /// </summary>
        public Guid idRool { get; set; }

        /// <summary>
        /// Email del usuario
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Identificador de company
        /// </summary>
        public Guid uicompany { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Foto { get; set; }





    }
}
