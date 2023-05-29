using Microsoft.AspNetCore.Mvc;
using static apiTest.Controllers.CarrController;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrController : ControllerBase
    {
        private static List<Carr> carrs = new List<Carr>();
        // GET: api/<CarrController>
        [HttpGet]
        public IEnumerable<Carr> Get()
        {
            return carrs;
        }

        // GET api/<CarrController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
          //  return "value";
        //}

        // POST api/<CarrController>
        [HttpPost]
        public IActionResult Post([FromBody] Carr objParams)
        {
            carrs.Add(objParams);
            return Ok();
        } 

        public class Carr
        {
            public string Fabric { get; set; }
            public string Age { get; set; }

        }

        // PUT api/<CarrController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<CarrController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
