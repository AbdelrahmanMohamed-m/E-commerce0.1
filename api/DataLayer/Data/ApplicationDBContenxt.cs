using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DataLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.DataLayer.Data
{
    public class ApplicationDBContenxt : IdentityDbContext<AppUser>
    {

        public ApplicationDBContenxt(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Payment> Payments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            List<IdentityRole> roles =
           [
               new IdentityRole{Name = "Admin", NormalizedName = "ADMIN"},
               new IdentityRole{Name = "User", NormalizedName = "USER"}
           ];
            modelBuilder.Entity<IdentityRole>().HasData(roles);

            modelBuilder.Entity<OrderItem>().HasKey(oi => new { oi.OrderId, oi.ProductId });
            modelBuilder.Entity<OrderItem>().HasOne(oi => oi.Order).WithMany(o => o.OrderItems).HasForeignKey(oi => oi.OrderId);
            modelBuilder.Entity<OrderItem>().HasOne(oi => oi.Product).WithMany(p => p.OrderItems).HasForeignKey(oi => oi.ProductId);

        }

    }

}