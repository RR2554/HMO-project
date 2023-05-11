using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DB : DbContext
    {
        public DbSet<Member> Members { get; set; }

        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<Corona_Details> Corona_Details { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=HMO.DB;trusted_connection=true");
        }
    }
}