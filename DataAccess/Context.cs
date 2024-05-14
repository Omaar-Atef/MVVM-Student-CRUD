using Microsoft.EntityFrameworkCore;
using MVVM_D2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_D2.DataAccess
{
    public class Context :DbContext
    {
        public DbSet<Student> Students {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SchoolSystem;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
