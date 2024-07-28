using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.DAL
{
    internal interface IExcelDataAccess<T>
    {
        List<T> load();
        void save(List<T> data);
        void close();
    }
}
