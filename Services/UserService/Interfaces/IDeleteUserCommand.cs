using System;
using System.Net;

namespace IDeleteUserUserService.Interfaces
{
    public interface IDeleteUserCommand
    {
        void Execute(Guid userId);
    }
}
