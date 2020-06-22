using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Domain.Identity.Contexts
{
    
   public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRoles,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
             
        }
      
    }
}
