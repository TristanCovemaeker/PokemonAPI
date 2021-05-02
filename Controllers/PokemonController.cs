using System;
using Microsoft.AspNetCore.Mvc;

namespace PokemonAPI.Controllers
{
    [ApiController]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        [Route("pokemon")]
        public ActionResult<string> GetPokemon(){
            return new OkObjectResult("Test geslaagd");
        }
    }
}
