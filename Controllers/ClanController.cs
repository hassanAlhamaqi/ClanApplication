using ClanApplication.Models;
using ClanApplication.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClanApplication.Controllers
{
    [Route("api/clan")]
    [ApiController]
    public class ClanController : ControllerBase
    {
        private readonly ClanServices _clanServices;

        public ClanController(ClanServices clanServices)
        {
            _clanServices = clanServices;
        }

        // GET: api/clan
        [HttpGet]
        public async Task<List<Clan>> Get() => await _clanServices.GetAsync();

        // GET api/clan/663fccfc33fe59d025cb7819
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return "value";
        }

        // POST api/clan
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/clan/663fccfc33fe59d025cb7819
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
        }

        // DELETE api/clan/663fccfc33fe59d025cb7819
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
