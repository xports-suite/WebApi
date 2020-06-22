using Api_xports.Features.Base.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.User.DTO.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class AddUserAppRequest : ValidationModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string uiPerson { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string idRool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string uicompany { get; set; }

               
        

    }
}
