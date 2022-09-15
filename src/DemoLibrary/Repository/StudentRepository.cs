using DemoWebLibrary.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Repository
{
    public class StudentRepository:Repository,IStudentRepository
    {
        public StudentRepository(StudentDbContext context):base(context)
        {
                
        }
    }
}
