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




    }
}
