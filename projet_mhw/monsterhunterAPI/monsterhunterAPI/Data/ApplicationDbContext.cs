using Microsoft.AspNet.Identity.EntityFramework;
using monsterhunterAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using monsterhunterAPI.Models.ItemProperty;
using monsterhunterAPI.Models.Items;

namespace monsterhunterAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Items
        public virtual DbSet<Armor> Armors { get; set; }
        public virtual DbSet<Weapon> Weapons { get; set;}
        public virtual DbSet<Charm> Charms { get; set; }
        public virtual DbSet<Decoration> Decorations { get; set; }
        #endregion

        #region ItemProperty
        public virtual DbSet<Sharpness> Sharpnesses { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<ArmorSet> ArmorSets { get; set; }
        public virtual DbSet<WeaponType> WeaponType { get; set; }
        public virtual DbSet<DecorationSlotTable> DecorationSlotTalbes { get; set; }
        public virtual DbSet<DecorationSlot> DecorationSlots { get; set; }
        #endregion

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
            prepareSkill(modelBuilder);
        }

        #region builderItems
        private void prepareArmor(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Armor>();

            entity.HasKey(c => c.Id);

            entity.Property(c => c.Name).IsRequired();
        }

        private void prepareWeapon(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Weapon>();

            entity.HasKey(c => c.Id);

            entity.Property(c => c.Name).IsRequired();

            entity.HasRequired(c => c.Sharpness);

            entity.HasRequired(c => c.WeaponType);
        }
        
        private void prepareCharm(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Charm>();

            entity.HasKey(c => c.Id);

            entity.Property(c => c.Name).IsRequired();
        }

        private void prepareDecoration(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Decoration>();

            entity.HasKey(c => c.Id);
        }
        #endregion

        #region builderItemProperty
        private void prepareSharpness(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Sharpness>();

            entity.HasKey(c => c.Id);
        }

        private void prepareSkill(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Skill>();

            entity.HasKey(c => c.Id);

            entity.Property(c => c.skillDescription).IsRequired();
        }
        
        private void prepareArmorSet(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<ArmorSet>();

            entity.HasKey(c => c.Id);
        }

        private void prepareWeaponType(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<WeaponType>();

            entity.HasKey(c => c.Id);

            entity.Property(c => c.Name).IsRequired();
        }

        private void prepareDecorationSlotTable(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<DecorationSlotTable>();

            entity.HasKey(c => c.Id);
        }

        private void prepareDecorationSlot(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<DecorationSlot>();

            entity.HasKey(c => c.Id);
        }
        #endregion
    }
}