using Algorithms.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {

        /// <summary>
        ///Returns the nth number in the fibonacci sequence.
        /// </summary>
        /// <param name="n"></param> 
        // GET api/fibonacci/10
        [HttpGet()]
        public ActionResult<string> Get([FromServices]IFibonacci fibonacci, long n)
        {
            var result = fibonacci.GetFibonacciNumber(n);
            return result.ToString();
        }
    }
}
