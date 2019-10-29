using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Appuntamenti.Data;
using Appuntamenti.Models;
using Appuntamenti.Models.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Appuntamenti.Pages.Documents
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _hostingEnvironment;

        public CreateModel(ApplicationDbContext db, IHostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
        }

        [BindProperty]
        public DocumentModel documentModel { get; set; }

        [BindProperty]
        public DocumentCreateViewModel documentCreate { get; set; }


        public async Task<IActionResult> OnPostAsync(DocumentCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                string fileUniqueName = null;
                if(model.Document == null)
                {
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Documents");
                    fileUniqueName = Guid.NewGuid().ToString();
                    string filePath = Path.Combine(uploadsFolder, fileUniqueName);

                    if (filePath.Length > 0)
                    {
                        using (var fs = new FileStream(filePath, FileMode.Create))
                        {

                                fs.Position = 0;
                                await fs.CopyToAsync(fs);
                                fs.Close();
                            

                        }
                    }


                    DocumentModel newDocument = new DocumentModel
                    {
                        Name = documentModel.Name,
                        Description = documentModel.Description,
                        DocumentPath = fileUniqueName

                    };
                    _db.Add(newDocument);
                    await _db.SaveChangesAsync();
                }
            }

            return Page();
        }
    }
}