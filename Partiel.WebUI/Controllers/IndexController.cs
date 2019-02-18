using Newtonsoft.Json;
using Partiel.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Partiel.WebUI.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public async Task<ActionResult> Index()
        {
            IndexModel indexModel = new IndexModel();
            using (var client = new HttpClient())
            {
                var uri = new Uri("http://localhost:53847/api/events/get");

                var json = await client.GetStringAsync(uri);
                var result = JsonConvert.DeserializeObject<List<Event>>(json);
                indexModel.Events = result;
            }
            return View(indexModel);
        }
    }
}