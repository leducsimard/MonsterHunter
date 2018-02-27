using Microsoft.AspNet.Identity.EntityFramework;
using monsterhunterAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using monsterhunterAPI.Models.ItemProperty;

namespace monsterhunterAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Armor> Armors { get; set; }
        public virtual DbSet<Weapon> Weapons { get; set;}
        public virtual DbSet<Sharpness> Sharpnesses { get; set; }

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

            //Update model for code first
            prepareArmor(modelBuilder);
            prepareWeapon(modelBuilder);
            prepareSharpness(modelBuilder);
        }

        private void prepareArmor(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Armor>();

            entity.HasKey(c => c.Id);
        }

        private void prepareWeapon(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Weapon>();

            entity.HasKey(c => c.Id);

            entity.HasOptional(c => c.Sharpness)
                .WithRequired(c => c.Weapon);
        }

        private void prepareSharpness(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Sharpness>();

            entity.HasKey(c => c.Id);
        }
    }
}