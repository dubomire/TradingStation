using DataBaseService.DbModels;
using DataBaseService.Interfaces;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseService.Repositories
{
    public class UserRepository : IRepository<User>
    {
        readonly IMapper<User, DbUser> mapper;
        readonly DataBaseServiceContext dbContext;
        DbUser errUser = new DbUser("error user", "error user", "error user", "error user");

        public UserRepository(IMapper<User, DbUser> mapper, DataBaseServiceContext dbContext)
        {
            this.mapper = mapper;
            this.dbContext = dbContext;
        }

        public void Create(User newUser)
        {
            dbContext.Users.Add(mapper.CreateMap(newUser));
            dbContext.SaveChanges();
        }

        public void Delete(User obj)
        {
            dbContext.Users
                .Remove(mapper.CreateMap(obj));
            dbContext.SaveChanges();
        }

        public User Read(string id)
        {
            return mapper.CreateRemap(
                dbContext
                .Users
                .Where(u => u.Id == id)
                .DefaultIfEmpty(errUser)
                .FirstOrDefault());
        }

        public List<User> ReadAll()
        {
            List<User> users = new List<User>();

            Parallel.For(0, dbContext.Users.Count(),
                i =>
                {
                    users.Add(mapper.CreateRemap(dbContext.Users.ElementAt(i)));
                });

            return users;
        }

        /// <summary>
        /// Change user data
        /// </summary>
        /// <param name="id">Id user</param>
        /// <param name="obj">User with new data</param>
        public void Update(string id, User obj)
        {
            DbUser user = dbContext.Users
                .Where(u => u.Id == id)
                .DefaultIfEmpty(errUser)
                .FirstOrDefault();

            user = mapper.CreateMap(obj);

            dbContext.SaveChanges();
        }
    }
}
