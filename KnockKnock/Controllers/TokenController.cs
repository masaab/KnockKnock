using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {

        const string token= "46175645-01b0-4de9-9bc6-f30a2d3eb89b";


        /// <summary>
        /// Returns Token
        /// </summary>
        [HttpGet]
        public ActionResult<string> Get()
            => token;
    }
}