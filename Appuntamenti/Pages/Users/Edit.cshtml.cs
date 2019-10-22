using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appuntamenti.Data;
using Appuntamenti.Models;
using Appuntamenti.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Appuntamenti.Pages.Users
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public ApplicationUser Users { get; set; }
        public async Task<IActionResult> OnGetAsync(string id)
        {


            if (id == null)
            {
                return NotFound();
            }
            Users = await _db.ApplicationUser.FirstOrDefaultAsync(m => m.Id == id);

            if (Users == null)
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

            var UserFromDb = await _db.ApplicationUser.FirstOrDefaultAsync(s => s.Id == Users.Id);
            UserFromDb.Name = Users.Name;
            UserFromDb.Surname = Users.Surname;
            UserFromDb.Email = Users.Email;

            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}