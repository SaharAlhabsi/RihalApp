using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RihalDev.Models;
namespace RihalDev.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
         {
            Database.EnsureCreated();

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Classes> Classes { get; set; }
  
        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Students>().HasData(GetStudents());
            builder.Entity<Countries>().HasData(GetCountries());
            builder.Entity<Classes>().HasData(GetClasses());
            builder.Entity<Students>()
                     .HasOne<Classes>(b => b.Classes)
                     .WithMany(a => a.Students)
                     .HasForeignKey(b => b.class_id);

            builder.Entity<Students>()
                        .HasOne<Countries>(b => b.Countries)
                        .WithMany(a => a.Students)
                        .HasForeignKey(b => b.country_id);
            base.OnModelCreating(builder);
        }

        private List<Students> GetStudents()
        {
            List<Students> Students = new List<Students>();

            for (int i = 0; i < 20; i++)
            {
                Students.Add(new Students {
                    Id = (i + 1),
                    name = Faker.Name.FullName(),
                    birthDate = Faker.Identification.DateOfBirth(),
                    class_id = Faker.RandomNumber.Next(1,10),
                    country_id = Faker.RandomNumber.Next(1, 10),
                });
            }

            return Students;
        }
        private List<Classes> GetClasses()
        {
            List<Classes> Classes = new List<Classes>();

            for (int i = 0; i < 10; i++)
            {
                Classes.Add(new Classes
                {
                    Id = (i + 1),
                    name = Faker.Address.ZipCode()

                });
            }

            return Classes;
        }

        private List<Countries> GetCountries()
        {
            List<Countries> Countries = new List<Countries>();

            for (int i = 0; i < 10; i++)
            {
                Countries.Add(new Countries
                {
                    Id = (i + 1),
                    name = Faker.Address.City(),
                });
            }

            return Countries;
        }

      
    }
}
