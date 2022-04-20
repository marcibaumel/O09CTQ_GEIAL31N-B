using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitOfWork:DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<FilmModel> Films { get; set; }

        public UnitOfWork() : base("WatchlistDB") { }

    }
}
