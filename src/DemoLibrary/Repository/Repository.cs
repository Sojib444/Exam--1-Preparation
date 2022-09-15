using DemoWebLibrary;
using DemoWebLibrary.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Repository
{
    public  abstract class Repository : IRepository<Student>
    {
        public readonly StudentDbContext _context;
        public Repository(StudentDbContext context)
        {
            _context = context;
        }
        public virtual void Add( Student student)
        {
            _context.Students.Add(student);
        }

        public virtual void Delete(int id)
        {
            Student student = _context.Students.Find(id);
            _context.Students.Remove(student);
        }

        public virtual void get(int id)
        {
            _context.Students.Find(id);
        }

  
    }
}
