using Ghost.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghost.Database
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDBContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SQL8005.site4now.net;Initial Catalog=db_aa52ba_logins;User Id=db_aa52ba_logins_admin;Password=TestPass_1");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
