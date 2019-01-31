using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Algorithms.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriangleTypeController : ControllerBase
    {
        /// <summary>
        /// Returns the type of triange given the lengths of its sides 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        [HttpGet()]
        public ActionResult<TriangleTypes> Get([FromServices]ITriangleType triangleType, long a, long b, long c)
            => triangleType.GetTriangleType(a, b, c);
    }
}