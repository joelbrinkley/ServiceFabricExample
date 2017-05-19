using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fortune;

namespace FortuneService.Controllers
{
    [Produces("application/json")]
    [Route("api/fortune")]
    public class FortuneController : Controller
    {
        private FortuneTeller fortuneTeller;

        public FortuneController()
        {
            //TODO: figure out new dependency injection container
            var repository = new FortuneRepository();
            var crystalBall = new CrystalBall();
            this.fortuneTeller = new FortuneTeller(crystalBall, repository);
        }

        [HttpGet(Name ="GetFortune")]
        public async Task<IActionResult> GetFortune()
        {
            try
            {
                var fortune = await fortuneTeller.Tell();
                return Ok(fortune);
            }
            catch(Exception)
            {
                //TODO: is this right?
                return StatusCode(500);
            }
          
        }
    }
}