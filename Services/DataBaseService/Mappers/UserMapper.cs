using DataBaseService.DbModels;
using DataBaseService.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseService.Mappers
{
    public class UserMapper : IMapper<User, DbUser>
    {
        public DbUser CreateMap(User obj)
        {
            return new DbUser(obj.Id, obj.Login, obj.Email, obj.Password);
        }

        public User CreateRemap(DbUser obj)
        {
            return new User(obj.Id, obj.Login, obj.Email, obj.Password);
        }
    }
}
