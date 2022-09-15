using DemoWebLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebLibrary.Services
{
    public class StudentService: IStudentService
    {
        public void CreateStudentForyourResponsibility(BStudent student)
        {
            student.SetProperCGpa();
        }
    }
}
