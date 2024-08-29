using FireWolf.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireWolf
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connections.sqlConStr);
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<userRoles> userRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); 



            //builder.Entity<Orders>(b =>
            //{//current
            //    b.HasMany(st => st.orderId)
            //    .WithOne(st => st.OwnerUser)
            //    .HasForeignKey(st => st.UserId)
            //    .OnDelete(DeleteBehavior.ClientCascade); //for FK cycles
            //    //b.Property(x=>x.RoleID).HasDefaultValue(null);
            //});
        }
    }
}
