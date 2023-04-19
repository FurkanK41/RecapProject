using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class WorkContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Work;Trusted_connection=true");
        }

        void deneme(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Work;Trusted_connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }

        /*#region Custom Mapping
         public DbSet<Personel> Personels { get; set; }

                protected override void OnModelCreating(ModelBuilder modelBuilder)
                {
                    modelBuilder.Entity<Personel>().ToTable("Employees");
                    modelBuilder.Entity<Personel>().Property(p=>p.Id).HasColumnName("EmployeeId");
                    modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
                    modelBuilder.Entity<Personel>().Property(p => p.Surname).HasColumnName("LastName");
                }
        #endregion */
       
    }
}
