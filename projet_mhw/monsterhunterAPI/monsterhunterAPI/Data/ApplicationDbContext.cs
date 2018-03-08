using Microsoft.AspNet.Identity.EntityFramework;
using monsterhunterAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using monsterhunterAPI.Models.ItemProperty;
using monsterhunterAPI.Models.Items;
using monsterhunterAPI.Models.Items.Weapons;

namespace monsterhunterAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Items
        public virtual DbSet<Armor> Armors { get; set; }
        public virtual DbSet<Charm> Charms { get; set; }
        public virtual DbSet<Decoration> Decorations { get; set; }
        public virtual DbSet<Bow> Bows { get; set; }
        public virtual DbSet<ChargeBlade> ChargeBlades { get; set; }
        public virtual DbSet<GreatSword> GreatSwords { get; set; }
        public virtual DbSet<Gunlance> Gunlances { get; set; }
        public virtual DbSet<Hammer> Hammers { get; set; }
        public virtual DbSet<HeavyBowgun> HeavyBowguns { get; set; }
        public virtual DbSet<HuntingHorn> HuntingHorns { get; set; }
        public virtual DbSet<InsectGlaive> InsectGlaives { get; set; }
        public virtual DbSet<Lance> Lances { get; set; }
        public virtual DbSet<LightBowgun> LightBowguns { get; set; }
        public virtual DbSet<LongSword> LongSwords { get; set; }
        public virtual DbSet<SwitchAxe> SwitchAxes { get; set; }
        public virtual DbSet<SwordShield> SwordsShields { get; set; }
        #endregion

        #region ItemProperty
        public virtual DbSet<Sharpness> Sharpnesses { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<ArmorSet> ArmorSets { get; set; }
        public virtual DbSet<DecorationSlotTable> DecorationSlotTables { get; set; }
        public virtual DbSet<Element> Elements { get; set; }
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
            prepareCharm(modelBuilder);
            prepareDecoration(modelBuilder);
            prepareSharpness(modelBuilder);
            prepareSkill(modelBuilder);
            prepareDecorationSlotTable(modelBuilder);
            prepareElement(modelBuilder);
        }

        #region builderItems
        private void prepareGreatSword(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<GreatSword>();

            entity.HasKey(c => c.Id);
        }

        private void prepareArmor(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Armor>();

            entity.HasKey(c => c.Id);

            entity.Property(c => c.Name).IsRequired();
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
        private void prepareElement(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Element>();

            entity.HasKey(c => c.Id);
        }

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

        private void prepareDecorationSlotTable(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<DecorationSlotTable>();

            entity.HasKey(c => c.Id);
        }
        #endregion
    }
}