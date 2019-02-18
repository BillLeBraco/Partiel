using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partiel.Context
{
    public class StudentSevice
    {

        public List<Member> GetSeriousMember()
        {
            using (Db2019EventsStudentEntities context = new Db2019EventsStudentEntities())
            {
                return context.Members.Include("Participations").Where(m => m.Participations.Count == 0).ToList();
            }
        }

        public List<Member> GetStudentsNoDepense()
        {
            using (Db2019EventsStudentEntities context = new Db2019EventsStudentEntities())
            {
                return context.Participations.Include("Drinks").Include("Member").Where(p => p.Drinks.Count == 0).Select(p => p.Member).ToList();
            }
        }

        public List<Member> GetAlcoolicStudents()
        {
            using (Db2019EventsStudentEntities context = new Db2019EventsStudentEntities())
            {
                return context.Participations.Include("Drinks.DrinkType").Include("Member").Where(p => p.Drinks.All(d => d.DrinkType.AlcoholContent != 0)).Select(p => p.Member).ToList();
            }
        }
    }
}
