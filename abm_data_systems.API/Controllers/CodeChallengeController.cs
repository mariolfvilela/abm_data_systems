using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abm_data_systems.Application.Interfaces;
using abm_data_systems.Application.ViewModels.CodeChallenge;
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
        [HttpPut]
        [Route("Question1")]
        public async Task<IActionResult> Question1(
            [FromServices]ICodeChallengeAppService _repository,
            [FromBody] dynamic dado
        )
        {
            try
            {
                return new OkObjectResult(_repository.Question1(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // [Authorize("Bearer")]
        [AllowAnonymous]
        [Consumes("application/xml")]
        [Produces("application/xml")]
        [HttpPut]
        [Route("Question2")]
        public async Task<IActionResult> Question2(
            [FromServices]ICodeChallengeAppService _repository,
            [FromBody] InputDocumentViewModal dado
        )
        {
            try
            {
                return new OkObjectResult(await _repository.Question2(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // [Authorize("Bearer")]
        [AllowAnonymous]
        [Consumes("application/xml")]
        [Produces("application/xml")]
        [HttpPut]
        [Route("Question3")]
        public async Task<IActionResult> Question3(
            [FromServices]ICodeChallengeAppService _repository,
            [FromBody] InputDocumentViewModal dado
        )
        {
            try
            {
                return new OkObjectResult(await _repository.Question3(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
