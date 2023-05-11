using Bll;
using DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineController : ControllerBase
    {
        IVaccineBll vaccineBll;
        IMemberBll memberBll;
        public VaccineController(IVaccineBll vaccineBll, IMemberBll memberBll) {

            this.vaccineBll = vaccineBll; 
            this.memberBll=memberBll;
    }
            // GET: api/<VaccineController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VaccineController>/5
        [HttpGet("{id}")]
        public ActionResult getVaccinebyMemberId(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var vaccine = this.vaccineBll.getVaccinebyMemberId(id);
            if(vaccine== null) { return NotFound("the memeber is not found"); }
            return Ok(vaccine);
        }

        [HttpPost("{identity}")]

        public ActionResult AddVaccineToMember(string identity, [FromBody] VaccineDto value)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            var member = this.memberBll.getMemberbyId(identity);
            if (member == null) { return NotFound("there is no member with this identity"); }
            this.vaccineBll.AddVaccineToMember(identity, value);
            return Ok();
        }


       
    }
}
