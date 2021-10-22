using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete
{
   public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-S95JB6JC\\SQLEXPRESS01;database=TelephoneDirectoryDb; integrated security=true;");
        }
        public DbSet<Person> Persons { get; set; }
        

    }
}
