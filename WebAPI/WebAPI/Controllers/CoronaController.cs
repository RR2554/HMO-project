using Bll;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronaController : ControllerBase
    {
        IMemberBll memberBll;
        ICorona_DetailsBll corona_DetailsBll;
        public CoronaController(ICorona_DetailsBll corona_DetailsBll, IMemberBll memberBll)
        {
            this.corona_DetailsBll = corona_DetailsBll;
            this.memberBll = memberBll;
        }

        [HttpPost("{identity}")]

        public ActionResult AddCoronaToMember(string identity, [FromBody] Corona_DetailsDto value)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            // בדיקה שהתאריכים תקינים
            if(value.PositiveDate> value.recoveryDate) {
                throw new Exception("PositiveDate cannot be greater than recoveryDate");
              
            }
            if(value.PositiveDate> DateTime.Now || value.recoveryDate> DateTime.Now)
            {
                throw new Exception("Invalid date");
            }
            var member = this.memberBll.getMemberbyId(identity);
            if (member == null) { return NotFound("there is no member with this identity"); }
            this.corona_DetailsBll.AddCoronaToMember(identity, value);
            return Ok();
        }
        // GET: api/<CoronaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CoronaController>/5
        [HttpGet("{id}")]
        public ActionResult getCoronabyMemberId(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var corona = this.corona_DetailsBll.getCoronabyMemberId(id);
            if (corona == null) { return NotFound("the memeber is not found"); }
            return Ok(corona);
        }

        
    }
}
