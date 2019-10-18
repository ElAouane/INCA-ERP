using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appuntamenti.Data;
using Appuntamenti.Models;
using Appuntamenti.Models.ViewModel;
using Appuntamenti.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Appuntamenti.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public UsersListViewModel UsersListVM { get; set; }
        public async Task<IActionResult> OnGet(int productPage=1, string searchName = null, string searchSurname = null, string searchEmail = null)
        {
            UsersListVM = new UsersListViewModel()
            {
                ActiveUsers = await _db.ApplicationUser.ToListAsync()
            };
            StringBuilder param = new StringBuilder();
            param.Append("/Users?productPage=:");

            param.Append("&searchName=");
            if (searchName != null)
            {
                param.Append(searchName);
            }

            param.Append("&searchSurname=");
            if (searchSurname != null)
            {
                param.Append(searchSurname);
            }

            param.Append("&searchEmail=");
            if (searchEmail != null)
            {
                param.Append(searchEmail);
            }

            if (searchName != null)
            {
                UsersListVM.ActiveUsers = await _db.ApplicationUser.Where(u => u.Name.ToLower().Contains(searchName.ToLower())).ToListAsync();
            }
            else
            {
                if (searchSurname != null)
                {
                    UsersListVM.ActiveUsers = await _db.ApplicationUser.Where(u => u.Surname.ToLower().Contains(searchSurname.ToLower())).ToListAsync();
                }else
                {
                    if (searchEmail != null)
                    {
                        UsersListVM.ActiveUsers = await _db.ApplicationUser.Where(u => u.Email.ToLower().Contains(searchEmail.ToLower())).ToListAsync();
                    }
                }
            }


            var count = UsersListVM.ActiveUsers.Count;

            UsersListVM.PaginationInfo = new PaginationInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = SD.PaginationUsersPageSize,
                TotalItems = count,
                UrlParam = param.ToString()

            };
            UsersListVM.ActiveUsers = UsersListVM.ActiveUsers.OrderBy(p => p.Name)
                .Skip((productPage - 1) * SD.PaginationUsersPageSize)
                .Take(SD.PaginationUsersPageSize).ToList();
            return Page();
        }
    }
}