using Ef_Core_Initial.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Core_Initial.Data
{
    internal class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-IBV340F\\FULLSTACKDB;Database=initial_db;Trusted_Connection=True;Encrypt=False");
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Student> Students { get; set; }






    }
}
