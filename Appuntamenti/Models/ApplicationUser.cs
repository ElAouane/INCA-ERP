using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appuntamenti.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Area { get; set; }

    }
}
