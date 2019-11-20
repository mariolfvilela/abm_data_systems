using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abm_data_systems.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace abm_data_systems.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeChallengeController : Controller
    {
        // [Authorize("Bearer")]
        [AllowAnonymous]
        [HttpGet]
        [Route("Question1")]
        public async Task<IActionResult> Question1()
        {

            return StatusCode(200,
                    new UserViewModel()
                    { }
                    );
        }

        // [Authorize("Bearer")]
        [AllowAnonymous]
        [HttpGet]
        [Route("Question2")]
        public async Task<IActionResult> Question2()
        {

            return StatusCode(200,
                    new UserViewModel()
                    { }
                    );
        }

        // [Authorize("Bearer")]
        [AllowAnonymous]
        [HttpGet]
        [Route("Question3")]
        public async Task<IActionResult> Question3()
        {

            return StatusCode(200,
                    new UserViewModel()
                    { }
                    );
        }
    }
}
