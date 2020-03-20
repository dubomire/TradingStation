﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNetCore.Mvc;
using UserService.Interfaces;

namespace UserService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserServiceController : ControllerBase
    {
        [Route("EditUser")]
        [HttpPost]
        public HttpStatusCode EditUser([FromServices] IEditUser command, [FromBody] User user)
        {
            return command.Execute();
        }
    }
}