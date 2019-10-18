using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appuntamenti.Models.ViewModel
{
    public class UsersListViewModel
    {
        public List<ApplicationUser> ActiveUsers { get; set; }
        public PaginationInfo PaginationInfo { get; set; }
 
    }
}
