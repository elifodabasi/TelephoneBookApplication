using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.DataAccess.Configurations;
using TelephoneBook.DataAccess.Seeds;
using TelephoneBook.Entity;

namespace TelephoneBook.DataAccess.EntityFramework
{
    public class EfDbContext : DbContext
    {

        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {

        }
        public EfDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"User ID=postgres;Password=123;Host=localhost;Port=5432;Database=TelephoneBookDb;Pooling=true");

        }
        public DbSet<ContactInfo> ContactInfos;
        public DbSet<Person> Persons;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            #region ApplyEntiyConfiguration
            modelBuilder.ApplyConfiguration(new ContactInfoConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            #endregion

            #region ApplyEntitySeed
            modelBuilder.ApplyConfiguration(new PersonSeed(new Guid[] { new Guid("e98a2570-92e7-435e-a289-e5702987fa8e") }));
            modelBuilder.ApplyConfiguration(new ContactInfoSeed(new Guid[] { new Guid("e98a2570-92e7-435e-a289-e5702987fa8e") }));
            #endregion


        }






    }
    }
