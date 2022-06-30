using Apidb.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apidb
{
    public class ApiContext:DbContext
    {
        public ApiContext()
        { }
        public ApiContext(DbContextOptions options)
       : base(options)
        {

        }
        public DbSet<Teacher> Teachers{ get; set; }
        public DbSet<Classroom> Classroom { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAKSHMAN\MSSQLSERVER01;Database=Apidblayer;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }
}
