using DemoWebLibrary.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly StudentDbContext _context;

        public UnitofWork(StudentDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
