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
   

    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DetailsModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public IList<ApplicationUser> DetailUser { get; set; }
        public async Task<IActionResult> OnGet(string id)
        {

            if (id == null)
            {
                return NotFound();
            }
            DetailUser = await _db.ApplicationUser.Where(m => m.Id == id).ToListAsync();



           
            return Page();
        }
        


    }
}