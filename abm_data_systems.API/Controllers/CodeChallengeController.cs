using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abm_data_systems.Application.Interfaces;
using abm_data_systems.Application.ViewModels.Question3;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace abm_data_systems.API.Controllers
{
    [Produces("application/xml")]
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

            try
            {
                return new OkObjectResult(new{ });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // [Authorize("Bearer")]
        [AllowAnonymous]
        [HttpGet]
        [Route("Question2")]
        public async Task<IActionResult> Question2()
        {

            try
            {
                return new OkObjectResult(new { });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // [Authorize("Bearer")]
        [AllowAnonymous]
        [HttpGet]
        [Route("Question3")]
        public async Task<IActionResult> Question3(
            [FromServices]IQuestion3AppService _repository,
            [FromBody] DeclarationHeaderViewModal dado
        )
        {

            try
            {
                return new OkObjectResult(await _repository.GetStatus(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
