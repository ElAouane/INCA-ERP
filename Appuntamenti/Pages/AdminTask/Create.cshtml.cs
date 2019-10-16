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
        public AdminTasks AdminTask { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}