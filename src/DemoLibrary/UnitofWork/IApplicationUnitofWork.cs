using DemoLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.UnitofWork
{
    public interface IApplicationUnitofWork:IUnitofWork
    {
        IStudentRepository student { get; }
    }
}
