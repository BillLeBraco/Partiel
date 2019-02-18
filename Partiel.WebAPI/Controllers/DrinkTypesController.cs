using Partiel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Partiel.WebAPI.Controllers
{
    public class DrinkTypesController : ApiController
    {
        [Route("api/drinktypes/get")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            
            try
            {
                var res = DrinkTypesService.Get().Select(d => new { d.Id, d.Description, d.AlcoholContent });
                return Ok(res);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

    }
}
