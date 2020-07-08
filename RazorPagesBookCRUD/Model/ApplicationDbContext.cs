using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesBookCRUD.Model
{
    public class ApplicationDbContext : DbContext
    {
        //connect to SQL Server
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
    }
}
