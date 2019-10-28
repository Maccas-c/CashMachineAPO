using ATM_Machine.Data;
using CashMachine.Models.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Machine
{
    public class ATMDbContext : DbContext
    {
        public DbSet<Card> Card { get; set; }
        public DbSet<Owner> Owner { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Pika-Komputer\\SQLEXPRESS;Database=ATM_Machine;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().HasData(SeedData.GenerateOwners().ToArray());
            modelBuilder.Entity<Card>().HasData(SeedData.GenerateCards().ToArray());
        }

    }
}
