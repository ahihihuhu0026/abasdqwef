using System;
using System.Collections.Generic;

namespace CafeManagementSystem.BLL
{
    internal interface IBase<T>
    {
        List<T> getAll();

        T getById(int id);
    }
}
