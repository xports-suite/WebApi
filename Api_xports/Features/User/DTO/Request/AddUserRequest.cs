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
    public class AddUserRequest : ValidationModel
    {
        /// <summary>
        ///  
        /// </summary>
        public string uiCompany { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string idTypePersona { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Apellidos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Movil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TlfFijo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Direccion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Ciudad { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Provincia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigPostal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Foto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sexo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DNI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime FNacimiento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Nacionalidad { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Talla { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NumeroCuenta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool DomiciliarRecibos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Observaciones { get; set; }


    }
}
