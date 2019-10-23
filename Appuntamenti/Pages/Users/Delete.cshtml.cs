using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appuntamenti.Data;
using Appuntamenti.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Appuntamenti.Pages.Users
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public ApplicationUser DeleteUser { get; set; }

        
        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            DeleteUser = await _db.ApplicationUser.FirstOrDefaultAsync(u => u.Id == id);
            _db.ApplicationUser.Remove(DeleteUser);
            await _db.SaveChangesAsync();

            return RedirectToPage("../Users/Index");

        }
    }
}