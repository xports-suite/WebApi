using Microsoft.EntityFrameworkCore.Scaffolding.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class UsuarioRespository_Dto
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid UID_Company { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid UID_User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid UID_Person { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Foto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Empresa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NombreCompleto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Telefono { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Telefono2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DireccionCompleta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FechaNacimiento { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string  Sexo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid UID_TipoPersonal { get; set; }

        public string TipoPersona { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Observaciones { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DNI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Fecha_Alta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Fecha_Baja { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Apellidos { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public string Provincia { get; set; }

        public string CodigoPostal { get; set; }

        public string Nacionalidad { get; set; }

        public string Talla { get; set; }

        public string Num_Cuenta { get; set; }

        public bool DomiciliarRecibos { get;set; }



        /// <summary>
        /// 
        /// </summary>
        public int Opcion_Menu { get; set; }

    }
}
