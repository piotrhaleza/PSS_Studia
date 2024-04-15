using Microsoft.EntityFrameworkCore;
using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Data
{
    public class BaseContext : DbContext,IDisposable
    {
        public const string connectionString = @"Data Source=DESKTOPIOTR\SQLEXPRESS;Initial Catalog=TASKVIEWER;Integrated Security=True;TrustServerCertificate=True";
        public DbSet<Role> Roles { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<V_User> V_Users { set; get; }
        public DbSet<V_Role> V_Roles { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
                optionsBuilder.UseSqlServer(sqlConnectionStringBuilder.ToString());
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLES", "dbo").Property(x => x.Permissions).HasConversion(x => (byte)x, x => (Permission)x);
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS", "dbo");
            });

            modelBuilder.Entity<V_Role>(entity =>
            {
                entity.ToTable("V_ROLES", "dbo");
            });
            modelBuilder.Entity<V_User>(entity =>
            {
                entity.ToTable("V_USERS", "dbo");
            });
        }
    }
}

