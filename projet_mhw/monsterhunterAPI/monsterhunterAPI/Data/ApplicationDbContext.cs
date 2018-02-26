using Microsoft.AspNet.Identity.EntityFramework;
using monsterhunterAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace monsterhunterAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Armor> Armors { get; set; }
        public virtual DbSet<Weapon> Weapons { get; set;}

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Armor>().HasKey(c => c.Id);
            modelBuilder.Entity<Weapon>().HasKey(x => x.Id);
        }
    }
}