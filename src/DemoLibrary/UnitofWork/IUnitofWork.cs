using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.UnitofWork
{
    public interface IUnitofWork:IDisposable
    {
        void Save();
    }
}
