using Bll;
using DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/member")]
    [ApiController]
    public class MemberController : ControllerBase
    {
         
         IMemberBll memberBll;
        public MemberController(IMemberBll memberBll)
        {
            this.memberBll = memberBll;
        }
        // GET: api/<MemberController>
        [HttpGet]
        public List<MemberDto> Get()
        {
            return memberBll.getAllMembers();
        }

        // GET api/<MemberController>/5
        [HttpGet("{id}")]
        public MemberDto Get(string id)
        {
            return memberBll.getMemberbyId(id);
        }

        // POST api/<MemberController>
        [HttpPost]

        public ActionResult Post([FromBody] MemberDto value)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var m = memberBll.getMemberbyId(value.tz);
            if(m != null) { throw new Exception("Member already exists"); }
            memberBll.addMember(value);
            return Ok();
        }


       
    }
}
