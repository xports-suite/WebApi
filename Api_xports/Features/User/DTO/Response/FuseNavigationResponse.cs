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
    public class FuseNavigationResponse : ValidationModel
    {
        /// <summary>
        /// 
        /// </summary>
        public List<FNavigationN1Response> Navigation { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class FNavigationN1Response 
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string translate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string icon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<FNavigationN2Response> children { get; set; }



    }

    /// <summary>
    /// 
    /// </summary>
    public class FNavigationN2Response
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string translate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string icon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<FNavigationN3Response> children { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class FNavigationN3Response
    { 
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }

    }
}
