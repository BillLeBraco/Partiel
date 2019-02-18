using Newtonsoft.Json;
using Partiel.UI.IService;
using Partiel.UI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Partiel.UI.Service
{
    public class MainPageService : IMainPageService
    {
        public async Task<string> GetCoordonnees(string adresse)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri("http://dev.virtualearth.net/REST/v1/Locations?q=" + adresse + "&output=json&key=AiVtyKOfbie_p8qxC80wd3CXFWEANbXN_zSJcx9FdCV746v6At4qD-i-qjMWBhXU");

                var json = await client.GetStringAsync(uri);
                RootObject result = JsonConvert.DeserializeObject<RootObject>(json);
                //var res = result["resourceSets"][0]["resources"][0]["point"]["coordinates"];
                var coordonnes = result.resourceSets[0].resources[0].point.coordinates;
                return coordonnes[0] + "," + coordonnes[1];
            }
            //return "";
        }
    }
}
