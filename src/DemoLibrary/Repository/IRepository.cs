using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Repository
{
    public interface IRepository<T>
    {
        void Add( T item);
        void get(int id);
        void Delete(int id);

    }
}
