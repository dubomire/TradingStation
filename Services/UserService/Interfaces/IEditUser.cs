using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace UserService.Interfaces
{
    public interface IEditUser
    {
        HttpStatusCode Execute();
    }
}
