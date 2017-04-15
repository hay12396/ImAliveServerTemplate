using ImAliveServerTemplate.Models;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace ImAliveServerTemplate.Controllers
{
    [AllowAnonymous]
    //[Produces("application/json")]
    [Route("[controller]")]
    //[EnableCors("*", "*", "*")]
    public class APIController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _env;

        public APIController(ApplicationDbContext context, IHostingEnvironment env, IConfigurationRoot conf, bool startThreads = true)
        {
            _context = context;
            _env = env;
        }
        [HttpGet]
        [Route("[action]/{test}")]
        public async Task<IActionResult> Test1([FromRoute] string test)
        {
            try
            {
                return Ok(Json(test));
            }
            catch (Exception e)
            {
                return Ok(Json("Error"));
            }
        }     
    }
}
