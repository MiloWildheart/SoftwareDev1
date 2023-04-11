using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using LibararyBooks.MVVM.Model;

namespace LibararyBooks.MVVM.Model
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Authors> Authors { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set up many-to-one relationship between Item and Author
            modelBuilder.Entity<Items>()
                .HasOne<Authors>(i => i.Author)
                .WithMany(a => a.Items)
                .HasForeignKey(i => i.AuthorId)
                .IsRequired();

            // Set up many-to-one relationship between Item and MediaType
            modelBuilder.Entity<Items>()
                .HasOne<MediaType>(i => i.MediaType)
                .WithMany()
                .HasForeignKey(i => i.MediaTypeId)
                .IsRequired();

            // Seed data for MediaType table
            modelBuilder.Entity<MediaType>().HasData(
                new MediaType { Id = 1, Name = "Book" },
                new MediaType { Id = 2, Name = "CD" },
                new MediaType { Id = 3, Name = "DVD" }
            );
        }
    }

}
