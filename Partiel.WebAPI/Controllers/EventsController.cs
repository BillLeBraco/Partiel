using Partiel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Partiel.WebAPI.Controllers
{
    public class EventsController : ApiController
    {
        [HttpGet]
        [Route("api/events/get")]
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(EventsService.Get().Select(e => new { e.Id, e.Association.Name }));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("api/events/get/{id}/participants")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(EventsService.Get(id).Select(e => new { e.MemberId, e.Member.FirstName, e.Member.LastName, e.Credit }));
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
    }
}
