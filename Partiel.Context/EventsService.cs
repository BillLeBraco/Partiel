using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partiel.Context
{
   public static class EventsService
    {
        public static List<Event> Get()
        {
            using (Db2019EventsStudentEntities context = new Db2019EventsStudentEntities())
            {
                return context.Events.Include("Association").ToList();
            }
        }
        public static List<Participation> Get(int id)
        {
            using (Db2019EventsStudentEntities context = new Db2019EventsStudentEntities())
            {
                return context.Events.Include("Participations.Member").FirstOrDefault(e => e.Id == id).Participations.ToList();
            }
        }
    }
}
