using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appuntamenti.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Appuntamenti.Pages
{
    [Authorize(Roles = SD.AdminAccount)]
    public class AdminModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}