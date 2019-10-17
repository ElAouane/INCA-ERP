using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Appuntamenti.Data;
using Appuntamenti.Models;

namespace Appuntamenti.Pages.AdminTask
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public AdminTasks AdminTask { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AdminTask = await _db.AdminTasks.FirstOrDefaultAsync(m => m.Id == id);

            if (AdminTask == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //This Code will optimize the Server.
            //If we have hundreds of properties, this will modify
            //Only the properties we want without going
            //Trough all the database.
            var taskFromDb = await _db.AdminTasks.FirstOrDefaultAsync(s => s.Id == AdminTask.Id);
            taskFromDb.Name = AdminTask.Name;
            taskFromDb.Description = AdminTask.Description;
            taskFromDb.Date = DateTime.Now;
            
            await _db.SaveChangesAsync();


            return RedirectToPage("./Tasks");
        }

    }
}
