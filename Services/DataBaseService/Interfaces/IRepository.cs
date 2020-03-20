using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseService.Interfaces
{

    public interface IRepository<T>
    {
        void Create(T obj);
        T Read(string id);
        List<T> ReadAll();
        void Update(string id, T obj);
        void Delete(T obj);
    }
}
