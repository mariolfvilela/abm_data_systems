using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abm_data_systems.API.Extensions;
using abm_data_systems.Application.Interfaces;
using abm_data_systems.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace abm_data_systems.API.Controllers
{
    [Route("api/abm_data_systems")]
    public class HomeController : Controller
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate(
            [FromServices]IUserAppService app,
            [FromServices]IConfiguration iconfiguration,
            [FromBody]UserViewModel userViewModel)
        {
            var user = await app.Login(userViewModel.Username, userViewModel.Password);

            if (user == null)
                return NotFound(new { message = "Username or password is invalid" });

            string token = TokenService.GenerateToken(user, iconfiguration);
            return new OkObjectResult(new
            {
                user = user,
                token = token
            });
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee,manager")]
        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Gerente";
    }
}
