using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partiel.Context
{
    public static class DrinkService
    {

        public static int AddDrink(Drink drink)
        {
            using (Db2019EventsStudentEntities context = new Db2019EventsStudentEntities())
            {
                context.DrinkTypes.Attach(drink.DrinkType);
                context.Drinks.Add(drink);
                return context.SaveChanges();
            }
        }

    }
}
