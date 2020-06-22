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
    public class TokenResponse : ValidationModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string TokenBeear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RefresToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UICompany { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UIPerson { get; set; }

        internal override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            return base.Validate(validationContext);
        }
    }
}
