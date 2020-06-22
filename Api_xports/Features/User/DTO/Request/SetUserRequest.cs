using Api_xports.Features.Base.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.User.DTO.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class SetUserRequest : ValidationModel
    {

        
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string idTypePersona { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nombre { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string apellidos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string movil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fijo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string direccion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ciudad { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string provincia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string codigoPostal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string foto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sexo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dni { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? fechaNacimiento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string nacionalidad { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string talla { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string numCuenta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool domiciliarRecibos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string observaciones { get; set; }
    }
}
