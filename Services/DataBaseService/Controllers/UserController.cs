using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseService.Interfaces;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataBaseService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/User
        [HttpGet]
        public IEnumerable<User> GetAllUsers(
            [FromServices] IRepository<User> userRepository)
        {
            return userRepository.ReadAll();
        }

        // GET: api/User/5
        [HttpGet]
        public User GetUser(
            [FromServices] IRepository<User> userRepository,
            [FromBody] string id)
        {
            return userRepository.Read(id);
        }

        // POST: api/User
        [HttpPost]
        public void AddUser(
            [FromBody] User user,
            [FromServices] IRepository<User> userRepository)
        {
            userRepository.Create(user);
        }

        // PUT: api/User/5
        [HttpPut]
        public void ChangeUser(
            [FromBody] string id,
            [FromBody] User user,
            [FromServices] IRepository<User> userRepository)
        {
            userRepository.Update(id, user);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public void Delete(
            [FromBody] User user,
            [FromServices] IRepository<User> userRepository)
        {
            userRepository.Delete(user);
        }
    }
}
