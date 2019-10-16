using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appuntamenti.Data;
using Appuntamenti.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Appuntamenti.Pages.AdminTask
{
    public class CreateModel : PageModel
    {
        //RETRIEVE THE INFORMATION
        //FROM THE ADMINTASK TO PASS THEM THAN TO CREATE.CS
        public AdminTasks AdminTask { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}