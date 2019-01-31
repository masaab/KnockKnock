using Algorithms.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  
    public class ReverseWordsController : ControllerBase
    {
        /// <summary>
        ///Reverses the letters of each word in a sentence.
        /// </summary>
        /// <param name="sentence"></param> 
        // GET api/ReverseWords/and we shall win again
        [HttpGet()]
        public ActionResult<string> Get([FromServices]IReverseWord reverseWord, string sentence) 
            => reverseWord.GetReversedWords(sentence);
    }
}