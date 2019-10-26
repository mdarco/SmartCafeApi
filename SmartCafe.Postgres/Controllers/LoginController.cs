using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartCafe.Postgres.DTO;
using SmartCafe.Postgres.DAL;
using SmartCafe.Postgres.BL;

namespace SmartCafe.Postgres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUsersDal _dal;
        private readonly ILogger<LoginController> _logger;

        public LoginController(IUsersDal dal, ILogger<LoginController> logger)
        {
            this._dal = dal;
            this._logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> Login(LoginDto credentials)
        {
            if (credentials == null || string.IsNullOrEmpty(credentials.Username) || string.IsNullOrEmpty(credentials.Password))
            {
                return NoContent();
            }

            var user = await this._dal.GetUser(credentials.Username);
            if (user == null)
            {
                return Unauthorized();
            }

            if (!LoginManager.VerifyPassword(credentials.Password, user.Password))
            {
                return Unauthorized();
            }

            // TODO: create token
            string token = TokenManager.GenerateToken();

            return Ok(new { 
                Id = user.Id, Username = user.Username, FullName = user.FullName, UserGroups = user.UserGroups, Token = token
            });
        }
    }
}
