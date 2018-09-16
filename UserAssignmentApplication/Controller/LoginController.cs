using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using UserAssignmentApplication.Interface;
using UserAssignmentApplication.Model;

namespace UserAssignmentApplication.Controller
{
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginInterface _loginInterface;
        private readonly ILogger _log;

        public LoginController(ILoginInterface loginInterface, ILogger log)
        {
            _loginInterface = loginInterface;
            _log = log;
        }

        [HttpPost]
        [Route("api/Login/Create")]
        public async Task<string> Create([FromBody] User user)
        {
            _log.LogInformation("----------New User Created-----------");
            await _loginInterface.Create(user);
            return "User Created Successfully";
        }

        [HttpPost]
        [Route("api/Login/")]
        public async Task GetUser([FromBody] User user)
        {
            _log.LogInformation("-----------Retrieving User-----------");
            await _loginInterface.GetUser(user);
        }
    }
}