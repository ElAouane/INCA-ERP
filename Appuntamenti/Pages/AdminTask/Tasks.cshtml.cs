using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appuntamenti.Data;
using Appuntamenti.Models;
using Appuntamenti.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Appuntamenti.Pages.AdminTask
{



    [Authorize(Roles = SD.AdminAccount)]
    public class TasksModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public TasksModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<AdminTasks> AdminTasks { get; set; }
        public async Task<IActionResult> OnGet()
        {
            AdminTasks = await _db.AdminTasks.ToListAsync();
            return Page();
        }
    }
}