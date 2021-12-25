using MedShare.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedShare.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       public DbSet<Medicine> Medicines { get; set; } //kullanırken de medicines diye 
        //kullanıcaz.
       public DbSet<Sender> Senders { get; set; }
       public DbSet<Job> Jobs { get; set; }


    }
}
