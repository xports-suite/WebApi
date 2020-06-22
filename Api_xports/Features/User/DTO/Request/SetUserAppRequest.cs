using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.User.DTO.Request
{

    /// <summary>
    /// Clase que representa la modificacion de un usuario
    /// </summary>
    public class SetUserAppRequest
    {
        /// <summary>
        /// Identidicar de la persona
        /// </summary>
        public string uiPerson { get; set; }
        /// <summary>
        /// Identificador del Rool
        /// </summary>
        public string idRool { get; set; }

        /// <summary>
        /// email del usuario
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Identificador de la company
        /// </summary>
        public string uicompany { get; set; }

    }
}
