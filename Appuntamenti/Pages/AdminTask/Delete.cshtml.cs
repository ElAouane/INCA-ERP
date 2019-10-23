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
    public class DeleteModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public AdminTasks Tasks { get; set; }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AdminTasks Tasks = _db.AdminTasks.Find(id);

            if(Tasks == null)
            {
                return NotFound();
            }

            return Page();
        }

        //[HttpPost, ActionName("Delete")]

        public async Task<IActionResult> OnGetAsync(int id)
        {
            AdminTasks Tasks = await _db.AdminTasks.FindAsync(id);
            _db.AdminTasks.Remove(Tasks);
            await _db.SaveChangesAsync();
            return RedirectToPage("Tasks");

        }
    }
}