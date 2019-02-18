using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partiel.Context
{
    public static class DrinkTypesService
    {
        public static List<DrinkType> Get()
        {
            using (Db2019EventsStudentEntities context = new Db2019EventsStudentEntities())
            {
                return context.DrinkTypes.ToList();
            }
        }
    }
}
