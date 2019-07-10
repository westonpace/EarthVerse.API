using EarthVerse.API.Domains.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarthVerse.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Item> Item { get; set; }
        public DbSet<Equipment> Equipment { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Item>().ToTable("Item");

            builder.Entity<Item>().HasKey(i => i.ItemID);
            builder.Entity<Item>().Property(i => i.ItemID).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Item>().Property(i => i.ItemName).IsRequired().HasMaxLength(30);
            // builder.Entity<Item>().HasOne(i => i.Equipment).WithOne(e => e.Item).HasForeignKey<Item>(p => p.ItemID);

            builder.Entity<Item>().HasData
            (
                new Item { ItemID = 101, ItemName = "Chainvest" }, // ItemID set manually due to in-memory provider
                new Item { ItemID = 102, ItemName = "Sweat Pants" }
            );

            builder.Entity<Equipment>().ToTable("Equipment");
            builder.Entity<Equipment>().HasKey(e => e.EquipmentID);
            builder.Entity<Equipment>().Property(e => e.EquipmentID).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Equipment>().Property(e => e.equipmentType).IsRequired();

            builder.Entity<Equipment>().HasData
            (
                new Equipment {  EquipmentID = 15, ItemID = 101, equipmentType = EquipmentType.Overall},
                new Equipment {  EquipmentID = 16, ItemID = 102, equipmentType = EquipmentType.Pants}
            );
        }
    }
}