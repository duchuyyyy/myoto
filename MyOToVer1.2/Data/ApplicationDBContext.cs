﻿using Microsoft.EntityFrameworkCore;
using MyOToVer1._2.Models;
using System.Collections.Generic;

namespace MyOToVer1._2.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }

        public  DbSet<Owner> Owners { get; set; }
        public DbSet<CarRental> CarRentals { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach(var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            } 
        }
    }
}
