using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }

        public virtual DbSet<Person> People {get;set;}
        public virtual DbSet<Address> Addresses {get;set;}
        public virtual DbSet<Book> Books {get;set;}
        public virtual DbSet<Writer> Writers {get;set;}
        public virtual DbSet<PublishingHouse> PublishingHouses {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=LibraryDb;Username=postgres;Password=fatma.0643");
            }
        }
    }
}
