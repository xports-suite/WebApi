using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class UserToken
    {
        public Guid Id { get; set; }
        public string User_Id { get; set; }
        public string Token { get; set; }
        public string RefresToken { get; set; }
    }
}
