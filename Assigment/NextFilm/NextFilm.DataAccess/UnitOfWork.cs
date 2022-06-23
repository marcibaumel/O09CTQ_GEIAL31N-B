using Microsoft.EntityFrameworkCore;
using NextFilm.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.DataAccess
{
    public class UnitOfWork:DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WatchlistDB;");
        }
    }
}
