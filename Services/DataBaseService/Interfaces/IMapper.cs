using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseService.Interfaces
{
    /// <summary>
    /// Interface contains methods for mapping
    /// </summary>
    /// <typeparam name="T1">Business object</typeparam>
    /// <typeparam name="T2">Database object</typeparam>
    public interface IMapper<T1, T2>
    {
        T2 CreateMap(T1 obj);
        T1 CreateRemap(T2 obj);
    }
}
