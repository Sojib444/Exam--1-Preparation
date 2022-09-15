using DemoLibrary.Repository;
using DemoWebLibrary.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.UnitofWork
{
    public class ApplicationUnitOfWork : UnitofWork, IApplicationUnitofWork
    {
        public IStudentRepository student { get; private set; }
        public ApplicationUnitOfWork(StudentDbContext context,IStudentRepository studentRepository)
            :base(context)
        {
            student = studentRepository;
        }
        

    }
}
