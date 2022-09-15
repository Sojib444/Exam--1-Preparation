using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebLibrary.ApplicationDbContext
{
    public  class StudentDbContext:DbContext
    {
        private readonly string _connectionstring;
        private readonly string _assemblyname;

        public StudentDbContext(string connectionstring,string assemblyname)
        {
            _connectionstring = connectionstring;
            _assemblyname = assemblyname;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionstring,
                    b => b.MigrationsAssembly(_assemblyname)
                );
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Students { get; set; }

    }
}
