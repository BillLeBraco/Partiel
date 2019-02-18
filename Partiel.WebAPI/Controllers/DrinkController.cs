using Partiel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Partiel.WebAPI.Controllers
{
    public class DrinkController : ApiController
    {

        [HttpPost]
        [Route("api/drink")]
        public IHttpActionResult Post([FromBody] Drink drink)
        {
            try
            {
                if(DrinkService.AddDrink(drink) > 0)
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

    }
}
