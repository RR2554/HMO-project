using Bll;
using DTO;
using Entity;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/member")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        DB db;
         IMemberBll memberBll;
        public MemberController(IMemberBll memberBll, DB db)
        {
            this.memberBll = memberBll;
            this.db = db;
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
            var m = db.Members.FirstOrDefault<Member>(x => x.tz == value.tz);
            if (m != null) {return NotFound("Member already exists"); }
            memberBll.addMember(value);
            return Ok();
        }


       
    }
}
