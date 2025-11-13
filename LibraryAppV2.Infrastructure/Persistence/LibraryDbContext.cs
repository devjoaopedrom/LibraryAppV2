using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAppV2.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAppV2.Infrastructure.Persistence
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
    : base(options)
        {

        }

        public DbSet<Book> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BookComment> Comments { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<BookComment>(e =>
                {
                    e.HasKey(bc => bc.Id);
                    e.HasOne(bc => bc.Book)
                     .WithMany(b => b.CommentList)
                     .HasForeignKey(bc => bc.IdBook)
                     .OnDelete(DeleteBehavior.Restrict);

                    e.HasOne(bc => bc.User)
                     .WithMany(u => u.Comments)
                     .HasForeignKey(bc => bc.IdUser)
                     .OnDelete(DeleteBehavior.Restrict);
                });

            base.OnModelCreating(builder);
        }




    }
}
