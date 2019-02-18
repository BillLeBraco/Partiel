using Partiel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partiel.WebUI.Models
{
    public class IndexModel
    {
        public List<Event> Events { get; set; }
        public IndexModel()
        {
            Events = new List<Event>();
        }
    }
}