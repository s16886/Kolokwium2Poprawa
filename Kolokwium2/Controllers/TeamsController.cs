using Kolokwium2.Exceptions;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kolokwium2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public TeamsController(IDbService dbService)
        {
            _dbService = dbService;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetTeamAsync(int id)//change name to Async later
        {
            try
            {
                var team = await _dbService.GetTeamAsync(id);
                return Ok(team);
            }
            catch (TeamNotFoundException exc)
            {
                return BadRequest(exc.Message);
            }
            
        }
    }
}
