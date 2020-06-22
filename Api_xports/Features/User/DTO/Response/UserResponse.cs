using Api_xports.Features.Base.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.User.DTO.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class UserResponse : ValidationModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Foto { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UiCompany { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? IdTypePerson { get; set; }
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
        public string NombreCompleto { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TlfMovil { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TflFijo { get; set; }

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
        public string CodigoPostal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sexo { get; set; }
        /// <summary>
        /// /
        /// </summary>
        public string DNI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FNacimiento { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Nacionalidad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Provincia { get; set; }
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
        public Boolean DomiciliarRecibos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OpcionMenu { get; set; }





      


        





    }
    /// <summary>
    /// 
    /// </summary>
    public class UserCollectionReponse :ValidationModel
    {
        /// <summary>
        /// 
        /// </summary>
        public List<UserResponse> Users { get; set; }
    }
}
