﻿using System;
using System.Collections.Generic;
using System.Text;
using Appuntamenti.Models;
using Appuntamenti.Models.ViewModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Appuntamenti.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AdminTasks> AdminTasks { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<DocumentModel> Documents { get; set; }
    }
}
