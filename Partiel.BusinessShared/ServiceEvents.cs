using Newtonsoft.Json;
using Partiel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Partiel.BusinessShared
{
    public static class ServiceEvents
    {
       public static async Task<List<Event>> GetEvents()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri("http://localhost:53847/api/events/get");

                var json = await client.GetStringAsync(uri);
                var result = JsonConvert.DeserializeObject(json);
                return result;
            }
            
        }


    }
}
