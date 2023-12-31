﻿using INVENTARIO.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace INVENTARIO
{
        public class SampleContext : DbContext
        {
            public SampleContext(DbContextOptions<SampleContext> options) : base(options)
            {
            }
        private readonly string? _connectionString;
        public SampleContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionString != null)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderXProduct> OrderXProduct { get; set; }
    }

}
