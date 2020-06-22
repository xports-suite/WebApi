using Api_xports.Features.Base.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.User.DTO.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class AddUserResponse : ValidationModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string IdUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Rol { get; set; }

        internal override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            return base.Validate(validationContext);
        }
    }
}
