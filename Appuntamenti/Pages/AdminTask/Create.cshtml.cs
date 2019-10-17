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

        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }




        //RETRIEVE THE INFORMATION
        //FROM THE ADMINTASK TO PASS THEM THAN TO CREATE.CS
        [BindProperty]
        public AdminTasks AdminTask { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }

        //ADD POST HANDLER
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.AdminTasks.Add(AdminTask);
            await _db.SaveChangesAsync();

            return RedirectToPage("Tasks");
        }
    }
}